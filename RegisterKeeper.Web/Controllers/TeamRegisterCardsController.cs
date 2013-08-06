using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Controllers
{
	public class TeamRegisterCardsController : Controller
	{
		private readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		//
		// GET: /TeamRegisterCards/

		public ActionResult Index()
		{
			return View(_db.TeamRegisterCards.ToList());
		}

		//
		// GET: /TeamRegisterCards/Details/5

		public ActionResult Details(int id = 0)
		{
			TeamRegisterCard teamregistercard = _db.TeamRegisterCards.Find(id);
			if (teamregistercard == null)
			{
				return HttpNotFound();
			}
			return View(teamregistercard);
		}

		//
		// GET: /TeamRegisterCards/Create

		public ActionResult Create(int teamCompetitionId)
		{
			ViewBag.TeamCompetitionId = teamCompetitionId;
			return View();
		}

		//
		// POST: /TeamRegisterCards/Create

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TeamRegisterCard teamregistercard)
		{
			if (ModelState.IsValid)
			{
				_db.TeamRegisterCards.Add(teamregistercard);
				_db.SaveChanges();
				return RedirectToAction("Details", "TeamCompetitions", new { id = teamregistercard.TeamCompetitionId});
			}

			return View(teamregistercard);
		}

		//
		// GET: /TeamRegisterCards/Edit/5

		public ActionResult Edit(int id = 0)
		{
			TeamRegisterCard teamregistercard = _db.TeamRegisterCards.Find(id);
			if (teamregistercard == null)
			{
				return HttpNotFound();
			}
			var competition = _db.Competitions.Find(teamregistercard.TeamCompetitionId);
			IndividualRegisterCardsController.AddCompetitionDetailsToViewBag(competition, ViewBag);
			return View(teamregistercard);
		}

		//
		// POST: /TeamRegisterCards/Edit/5

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(TeamRegisterCard teamregistercard)
		{
			if (ModelState.IsValid)
			{
				foreach (var individualRegisterCard in teamregistercard.IndividualRegisterCards)
				{

					foreach (var shoot in individualRegisterCard.Shoots)
					{
						foreach (var sightingShot in shoot.Sighters)
						{
							_db.Entry(sightingShot).State = sightingShot.Id == default(int) ? EntityState.Added : EntityState.Modified;
							_db.SaveChanges();
						}
						foreach (var scoringShot in shoot.ScoringShots)
						{
							_db.Entry(scoringShot).State = scoringShot.Id == default(int) ? EntityState.Added : EntityState.Modified;
							_db.SaveChanges();
						}
					}

					// Update entity
					_db.Entry(individualRegisterCard).State = EntityState.Modified;

					foreach (var shoot in individualRegisterCard.Shoots)
					{
						_db.Entry(shoot).State = shoot.Id == default(int) ? EntityState.Added : EntityState.Modified;
					}
				}

				_db.Entry(teamregistercard).State = EntityState.Modified;
				_db.SaveChanges();
				return RedirectToAction("Details", "TeamCompetitions", new { id = teamregistercard.TeamCompetitionId });

			}
			return View(teamregistercard);
		}

		//
		// GET: /TeamRegisterCards/Delete/5

		public ActionResult Delete(int id = 0)
		{
			TeamRegisterCard teamregistercard = _db.TeamRegisterCards.Find(id);
			if (teamregistercard == null)
			{
				return HttpNotFound();
			}
			return View(teamregistercard);
		}

		//
		// POST: /TeamRegisterCards/Delete/5

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			TeamRegisterCard teamregistercard = _db.TeamRegisterCards.Find(id);
			_db.TeamRegisterCards.Remove(teamregistercard);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult AddShooter(int teamRegistercardId)
		{
			ViewBag.RouteValues = new { teamRegistercardId };
			
			var teamRegisterCard = _db.TeamRegisterCards.Find(teamRegistercardId);
			IndividualRegisterCardsController.AddCompetitionDetailsToViewBag(teamRegisterCard.TeamCompetition, ViewBag);
			ViewBag.TeamRegisterCardId = teamRegistercardId;

			return View();
		}

		[HttpPost]
		public ActionResult AddShooter(IndividualRegisterCard individualRegisterCard)
		{
			if (ModelState.IsValid)
			{
				_db.IndividualRegisterCards.Add(individualRegisterCard);
				_db.SaveChanges();
				var teamRegisterCard = _db.TeamRegisterCards.Find(individualRegisterCard.TeamRegisterCardId);
				return RedirectToAction("Details", "TeamCompetitions", new { id = teamRegisterCard.TeamCompetitionId });
			}

			return View();
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}