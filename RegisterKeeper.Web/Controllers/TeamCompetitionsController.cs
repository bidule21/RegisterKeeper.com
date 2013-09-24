using System.Data;
using System.Linq;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Controllers
{
	public class TeamCompetitionsController : Controller
	{
		private readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		//
		// GET: /TeamCompetitions/

		public ActionResult Index()
		{
			return View(_db.TeamCompetitions.ToList());
		}

		//
		// GET: /TeamCompetitions/Details/5

		public ActionResult Details(int id = 0)
		{
			TeamCompetition teamcompetition = _db.TeamCompetitions.Find(id);
			if (teamcompetition == null)
			{
				return HttpNotFound();
			}
			return View(teamcompetition);
		}

		//
		// GET: /TeamCompetitions/Create

		public ActionResult Create()
		{
			return View();
		}

		//
		// POST: /TeamCompetitions/Create

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TeamCompetition teamcompetition)
		{
			if (ModelState.IsValid)
			{
				_db.Competitions.Add(teamcompetition);
				_db.SaveChanges();
				return RedirectToAction("Details", new { id = teamcompetition.Id });
			}

			return View(teamcompetition);
		}

		//
		// GET: /TeamCompetitions/Edit/5

		public ActionResult Edit(int id = 0)
		{
			TeamCompetition teamcompetition = _db.TeamCompetitions.Find(id);
			if (teamcompetition == null)
			{
				return HttpNotFound();
			}
			return View(teamcompetition);
		}

		//
		// POST: /TeamCompetitions/Edit/5

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(TeamCompetition teamcompetition)
		{
			if (ModelState.IsValid)
			{
				_db.Entry(teamcompetition).State = EntityState.Modified;
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(teamcompetition);
		}

		//
		// GET: /TeamCompetitions/Delete/5

		public ActionResult Delete(int id = 0)
		{
			TeamCompetition teamcompetition = _db.TeamCompetitions.Find(id);
			if (teamcompetition == null)
			{
				return HttpNotFound();
			}
			return View(teamcompetition);
		}

		//
		// POST: /TeamCompetitions/Delete/5

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			TeamCompetition teamcompetition = _db.TeamCompetitions.Find(id);
			_db.Competitions.Remove(teamcompetition);
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