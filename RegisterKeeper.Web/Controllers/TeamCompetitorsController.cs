using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Controllers
{
	public class TeamCompetitorsController : Controller
	{
		private readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		public ActionResult Details(int id)
		{
			var competitor = _db.TeamCompetitors.Find(id);
			if (competitor == null)
			{
				return HttpNotFound();
			}
			return View(competitor);
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