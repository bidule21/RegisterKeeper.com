using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using RegisterKeeper.Web.Hubs;
using RegisterKeeper.Web.Models;
using RegisterKeeper.Web.ViewModels;

namespace RegisterKeeper.Web.Controllers
{
	public class ShotsController : Controller
	{
		readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		public ActionResult Scorer(int shotId)
		{
			var viewModel = BuildViewModel(shotId);

			return View(viewModel);
		}

		public ActionResult SighterConversion(int shootId)
		{
			var shoot = _db.Shoots.Find(shootId);

			var sighterConversionViewModel = new SighterConversionViewModel
				{
					ShootId = shootId,
					CompetitionName = shoot.CompetitionName,
					CompetitorName = shoot.CompetitorName,
					Distance = shoot.Distance,
					SightingShots = shoot.Sighters.OrderBy(s => s.ShotNumber).ToList(),
					NextShotId = shoot.FirstToCount.Id
				};


			return View(sighterConversionViewModel);
		}

		public ActionResult ConvertBoth(int shootId)
		{
			var shoot = _db.Shoots.Find(shootId);

			// set first to count as value of first sighter
			shoot.FirstToCount.Score = shoot.FirstSighter.Score;
			shoot.FirstSighter.Converted = true;

			// set second to count as value of second sighter
			shoot.SecondToCount.Score = shoot.SecondSighter.Score;
			shoot.SecondSighter.Converted = true;

			_db.SaveChanges();


			RegisterKeeperHub.BroadcastScoreUpdateToClients(shoot.FirstToCount);
			RegisterKeeperHub.BroadcastScoreUpdateToClients(shoot.SecondToCount);

			// build view model for third to count
			var viewModel = BuildViewModel(shoot.ScoringShots.Single(s => s.ShotNumber == 3).Id);

			return View("Scorer", viewModel);
		}

		public ActionResult ConvertSecondOrOnly(int shootId)
		{
			var shoot = _db.Shoots.Find(shootId);

			shoot.FirstToCount.Score = shoot.FinalSighter.Score;
			shoot.FinalSighter.Converted = true;

			_db.SaveChanges();

			RegisterKeeperHub.BroadcastScoreUpdateToClients(shoot.FirstToCount);

			// build view model for second to count
			var viewModel = BuildViewModel(shoot.ScoringShots.Single(s => s.ShotNumber == 2).Id);

			return View("Scorer", viewModel);
		}

		private ScorerViewModel BuildViewModel(int shotId)
		{
			var shot = _db.Shots.Find(shotId);
			//var shoot = _db.Shoots.Find(shot.ShootId);
			var shoot = shot.Shoot;

			var viewModel = new ScorerViewModel
				{
					ShootId = shoot.Id,
					ShotId = shotId,
					Score = shot.Score,
					Sighter = false,
					FinalSighter = false, // default, conditionally updated below
					ShotNumber = shot.ShotNumber,
					RegisterCardId = shoot.RegisterCardId,
					TeamCompetitorId = shoot.TeamCompetitorId,
					Distance = shoot.Distance,
					CompetitorName = shoot.CompetitorName,
					CompetitionName = shoot.CompetitionName
				};

			if (shot is SightingShot)
			{
				viewModel.Sighter = true;
				if (shot.ShotNumber == 1) // first sighter
				{
					viewModel.PreviousShotId = null;
				}
				else
				{
					viewModel.PreviousShotId = shoot.Sighters.Single(s => s.ShotNumber == shot.ShotNumber - 1).Id;
				}

				if (shot.ShotNumber == shoot.Sighters.Count()) // last sighter
				{
					viewModel.FinalSighter = true;
					viewModel.NextShotId = shoot.ScoringShots.Single(s => s.ShotNumber == 1).Id;
				}
				else
				{
					viewModel.NextShotId = shoot.Sighters.Single(s => s.ShotNumber == shot.ShotNumber + 1).Id;
				}
			}
			else // scoring shot
			{
				if (shot.ShotNumber == 1) // first to count
				{
					viewModel.PreviousShotId = shoot.Sighters.Single(s => s.ShotNumber == shoot.Sighters.Count()).Id;
				}
				else
				{
					viewModel.PreviousShotId = shoot.ScoringShots.Single(s => s.ShotNumber == shot.ShotNumber - 1).Id;
				}

				if (shot.ShotNumber == shoot.ScoringShots.Count()) // last to count
				{
					viewModel.NextShotId = null;
				}
				else
				{
					viewModel.NextShotId = shoot.ScoringShots.Single(s => s.ShotNumber == shot.ShotNumber + 1).Id;
				}
			}
			return viewModel;
		}

		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
