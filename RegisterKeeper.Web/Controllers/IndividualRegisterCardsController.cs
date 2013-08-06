using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Controllers
{
	public class IndividualRegisterCardsController : Controller
	{
		private readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		//
		// GET: /IndividualRegisterCards/

		public ActionResult Index()
		{
			return View(_db.IndividualRegisterCards.ToList());
		}

		//
		// GET: /IndividualRegisterCards/Details/5

		public ActionResult Details(int id = 0)
		{
			IndividualRegisterCard individualregistercard = _db.IndividualRegisterCards.Find(id);
			if (individualregistercard == null)
			{
				return HttpNotFound();
			}
			return View(individualregistercard);
		}

		//
		// GET: /IndividualRegisterCards/Create

		public ActionResult CreateForIndividualCompetition(int individualCompetitionId)
		{
			var competition = _db.Competitions.Find(individualCompetitionId);
			AddCompetitionDetailsToViewBag(competition, ViewBag);
			return View();
		}

		//
		// POST: /IndividualRegisterCards/Create

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreateForIndividualCompetition(IndividualRegisterCard individualregistercard)
		{
			if (ModelState.IsValid)
			{
				_db.IndividualRegisterCards.Add(individualregistercard);
				_db.SaveChanges();
				return RedirectToAction("Details", "IndividualCompetition", new { id = individualregistercard.IndividualCompetitionId });
			}

			if (individualregistercard.IndividualCompetitionId != null)
			{
				var competition = _db.Competitions.Find(individualregistercard.IndividualCompetitionId.Value);
				AddCompetitionDetailsToViewBag(competition, ViewBag);
			}

			return View();
		}

		//
		// GET: /IndividualRegisterCards/Edit/5

		public ActionResult EditForIndividualCompetition(int id = 0)
		{
			IndividualRegisterCard individualregistercard = _db.IndividualRegisterCards.Find(id);
			if (individualregistercard == null)
			{
				return HttpNotFound();
			}

			if (individualregistercard.IndividualCompetitionId != null)
			{
				var competition = _db.Competitions.Find(individualregistercard.IndividualCompetitionId.Value);
				AddCompetitionDetailsToViewBag(competition, ViewBag);
			}

			return View(individualregistercard);
		}

		//
		// POST: /IndividualRegisterCards/Edit/5

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult EditForIndividualCompetition(IndividualRegisterCard individualregistercard)
		{
			if (ModelState.IsValid)
			{
				//// Add any new child entities..
				//foreach (var shoot in individualregistercard.Shoots)
				//{
				//	foreach (var sightingShot in shoot.Sighters.Where(s => s.Id == default(int)))
				//	{
				//		_db.Entry(sightingShot).State = EntityState.Added;
				//		_db.SaveChanges();
				//	}
				//	foreach (var scoringShot in shoot.ScoringShots.Where(s => s.Id == default(int)))
				//	{
				//		_db.Entry(scoringShot).State = EntityState.Added;
				//		_db.SaveChanges();
				//	}
				//}

				//// Update entity
				//_db.Entry(individualregistercard).State = EntityState.Modified;

				//foreach (var shoot in individualregistercard.Shoots)
				//{
				//	_db.Entry(shoot).State = EntityState.Modified;
				//	foreach (var sightingShot in shoot.Sighters)
				//	{
				//		_db.Entry(sightingShot).State = sightingShot.Id == default(int) ? EntityState.Added : EntityState.Modified;
				//	}
				//	foreach (var scoringShot in shoot.ScoringShots)
				//	{
				//		_db.Entry(scoringShot).State = scoringShot.Id == default(int) ? EntityState.Added : EntityState.Modified;
				//	}
				//}

				// Add any new child entities (it seems adding more than one new child object at a time causes a duplicate key exception..)
				foreach (var shoot in individualregistercard.Shoots)
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
				_db.Entry(individualregistercard).State = EntityState.Modified;

				foreach (var shoot in individualregistercard.Shoots)
				{
					_db.Entry(shoot).State = shoot.Id == default(int) ? EntityState.Added : EntityState.Modified;
				}

				_db.SaveChanges();
				return RedirectToAction("Details", "IndividualCompetition", new { id = individualregistercard.IndividualCompetitionId });
			}
			return View(individualregistercard);
		}

		//
		// GET: /IndividualRegisterCards/Delete/5

		public ActionResult Delete(int id = 0)
		{
			IndividualRegisterCard individualregistercard = _db.IndividualRegisterCards.Find(id);
			if (individualregistercard == null)
			{
				return HttpNotFound();
			}
			return View(individualregistercard);
		}

		//
		// POST: /IndividualRegisterCards/Delete/5

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			IndividualRegisterCard individualregistercard = _db.IndividualRegisterCards.Find(id);
			_db.IndividualRegisterCards.Remove(individualregistercard);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		internal static void AddCompetitionDetailsToViewBag(Competition competition, dynamic viewBag)
		{
			viewBag.CompetitionId = competition.Id;
			viewBag.CompetitionName = competition.Name;
			viewBag.Distances = competition.Distances.ToList();
			viewBag.NumberOfSightingShots = competition.NumberOfSightingShots;
			viewBag.NumberOfScoringShots = competition.NumberOfScoringShots;
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}