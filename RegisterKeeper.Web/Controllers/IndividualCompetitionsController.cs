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
	public class IndividualCompetitionsController : Controller
	{
		private readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		//
		// GET: /IndividualCompetition/

		public ActionResult Index()
		{
			return View(_db.IndividualCompetitions.ToList());
		}

		//
		// GET: /IndividualCompetition/Details/5

		public ActionResult Details(int id = 0)
		{
			IndividualCompetition individualcompetition = _db.IndividualCompetitions.Find(id);
			if (individualcompetition == null)
			{
				return HttpNotFound();
			}
			return View(individualcompetition);
		}

		//
		// GET: /IndividualCompetition/Create
		[Authorize]
		public ActionResult Create()
		{
			return View();
		}

		//
		// POST: /IndividualCompetition/Create

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IndividualCompetition individualcompetition)
		{
			if (ModelState.IsValid)
			{
				_db.Competitions.Add(individualcompetition);
				_db.SaveChanges();
				return RedirectToAction("Details", new { id = individualcompetition.Id });
			}

			return View(individualcompetition);
		}

		//
		// GET: /IndividualCompetition/Edit/5

		public ActionResult Edit(int id = 0)
		{
			var individualcompetition = _db.IndividualCompetitions.Find(id);
			if (individualcompetition == null)
			{
				return HttpNotFound();
			}
			
			return View(individualcompetition);
		}

		//
		// POST: /IndividualCompetition/Edit/5

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(IndividualCompetition individualcompetition)
		{
			if (ModelState.IsValid)
			{
				_db.Entry(individualcompetition).State = EntityState.Modified;
				_db.SaveChanges();
				return RedirectToAction("Details", new { id = individualcompetition.Id });
			}
			return View(individualcompetition);
		}

		//
		// GET: /IndividualCompetition/Delete/5

		public ActionResult Delete(int id = 0)
		{
			IndividualCompetition individualcompetition = _db.IndividualCompetitions.Find(id);
			if (individualcompetition == null)
			{
				return HttpNotFound();
			}
			return View(individualcompetition);
		}

		//
		// POST: /IndividualCompetition/Delete/5

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			IndividualCompetition individualcompetition = _db.IndividualCompetitions.Find(id);
			_db.Competitions.Remove(individualcompetition);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}