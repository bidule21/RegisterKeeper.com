using System.Linq;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Controllers
{
	public class ShootsController : Controller
	{
		readonly RegisterKeeperDb _db = new RegisterKeeperDb();

		public ActionResult Edit(int individualregistercardid, Distance distance)
		{
			var registerCard = _db.IndividualRegisterCards.Find(individualregistercardid);
			var shoot = registerCard.Shoots.Single(s => s.Distance == distance);
			return View(shoot);
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