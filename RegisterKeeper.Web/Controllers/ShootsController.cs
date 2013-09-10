using System.Linq;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;
using RegisterKeeper.Web.ViewModels;

namespace RegisterKeeper.Web.Controllers
{
	public class ShootsController : Controller
	{
		readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		//public ActionResult Edit(int registerCardId, Distance distance)
		//{
		//	var registerCard = _db.RegisterCards.Find(registerCardId);
		//	var shoot = registerCard.Shoots.Single(s => s.Distance == distance);
		//	var competition = registerCard.IndividualCompetition;

		//	if (shoot.Sighters.Count == 0)
		//	{
		//		foreach (var sighterNumber in Enumerable.Range(1, competition.NumberOfSightingShots))
		//		{
		//			shoot.Sighters.Add(new SightingShot { ShotNumber = sighterNumber });
		//		}

		//		foreach (var scoringShotNumber in Enumerable.Range(1, competition.NumberOfScoringShots))
		//		{
		//			shoot.ScoringShots.Add(new ScoringShot { ShotNumber = scoringShotNumber });
		//		}

		//		_db.SaveChanges();
		//	}


		//	return RedirectToAction("Scorer", "Shots", new { shotId = shoot.Sighters.Single(s => s.ShotNumber == 1).Id });
		//}

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