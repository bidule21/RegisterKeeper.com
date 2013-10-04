using System;
using System.Linq;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;
using RegisterKeeper.Web.ViewModels.Home;

namespace RegisterKeeper.Web.Controllers
{
	public class HomeController : Controller
	{
		readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		public ActionResult Index()
		{
			var viewModel = new IndexViewModel
				{
					LiveCompetitions =
						_db.Competitions
						.Where(c => c.StartDateTime <= DateTime.Now && DateTime.Now <= c.EndDateTime)
						.OrderBy(c => c.StartDateTime).ThenBy(c => c.Name)
						.ToList(),
					CompletedCompetitions = 
						_db.Competitions
						.Where(c => c.EndDateTime < DateTime.Now)
						.OrderByDescending(c => c.StartDateTime).ThenBy(c => c.Name)
						.ToList(),
					UpcomingCompetitions = 
						_db.Competitions
						.Where(c => c.StartDateTime > DateTime.Now)
						.OrderBy(c => c.StartDateTime).ThenBy(c => c.Name)
						.ToList()
				};

			return View(viewModel);
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
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
