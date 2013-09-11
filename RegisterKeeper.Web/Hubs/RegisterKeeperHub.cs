using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Hubs
{
	public class RegisterKeeperHub : Hub
	{
		public void SaveScore(int shotId, string score)
		{
			using (var db = new RegisterKeeperDb())
			{
				var shot = db.Shots.Find(shotId);
				shot.ScoreText = score;
				db.SaveChanges();

				BroadcastScoreUpdateToClients(shot, Clients);
			}
		}

		private static void BroadcastScoreUpdateToClients(Shot shot, IHubConnectionContext clients)
		{
			clients.All.ScoreUpdate(shot.Id, shot.ScoreText);

			var shoot = shot.Shoot;
			clients.All.ShootTotalScoreUpdate(shoot.Id, shoot.TotalScore.ToString());

			if (shoot.RegisterCardId.HasValue)
			{
				var registerCard = shoot.RegisterCard;
				clients.All.RegisterCardTotalScoreUpdate(registerCard.Id, registerCard.TotalScore.ToString());
				clients.All.RegisterCardSortOrderUpdate(registerCard.Id, registerCard.SortOrder);
			}
		}


		// static interface for use by MVC controllers

		public static void BroadcastScoreUpdateToClients(Shot shot)
		{
			var clients = GlobalHost.ConnectionManager.GetHubContext<RegisterKeeperHub>().Clients;
			BroadcastScoreUpdateToClients(shot, clients);
		}
	}
}