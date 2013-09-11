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

			//foreach (var individualCompetition in viewModel.CompletedCompetitions.OfType<IndividualCompetition>())
			//{
			//	_db.Entry(individualCompetition).Collection(c => c.RegisterCards).Query().Include(s => s.Shoots.Select(shoot => shoot.ScoringShots)).Load();
			//}
			

			//var competitions = _db.Competitions.ToList();
			//var individualCompetitions = _db.IndividualCompetitions.ToList();

			//ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View(viewModel);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

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
