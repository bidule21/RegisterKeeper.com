using System.Collections.Generic;
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
				return RedirectToAction("Details", "TeamCompetitions", new { id = teamregistercard.TeamCompetitionId });
			}

			return View(teamregistercard);
		}

		//
		// GET: /TeamRegisterCards/Edit/5

		public ActionResult Edit(int id = 0)
		{
			var teamregistercard = _db.TeamRegisterCards.Find(id);
			if (teamregistercard == null)
			{
				return HttpNotFound();
			}
			//var competition = _db.Competitions.Find(teamregistercard.TeamCompetitionId);
			//RegisterCardsController.AddCompetitionDetailsToViewBag(competition, ViewBag);
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
				foreach (var firer in teamregistercard.Firers)
				{

					foreach (var shoot in firer.Shoots)
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
					_db.Entry(firer).State = EntityState.Modified;

					foreach (var shoot in firer.Shoots)
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

		public ActionResult AddCompetitor(int teamRegistercardId)
		{
			var teamRegisterCard = _db.TeamRegisterCards.Find(teamRegistercardId);

			var teamCompetitor = new TeamCompetitor
				{
					TeamRegisterCardId = teamRegistercardId,
					TeamRegisterCard = teamRegisterCard,
					Shoots = new List<Shoot>()
				};

			var competition = teamRegisterCard.TeamCompetition;

			teamCompetitor.InitialiseShoots(competition.Distances.ToList(), competition.NumberOfSightingShots, competition.NumberOfScoringShots);

			

			return View(teamCompetitor);
		}

		[HttpPost]
		public ActionResult AddCompetitor(TeamCompetitor teamCompetitor)
		{
			if (ModelState.IsValid)
			{
				_db.TeamCompetitors.Add(teamCompetitor);
				_db.SaveChanges();
				var teamRegisterCard = _db.TeamRegisterCards.Find(teamCompetitor.TeamRegisterCardId);
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