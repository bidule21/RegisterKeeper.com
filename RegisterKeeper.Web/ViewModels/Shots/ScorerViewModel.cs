using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.ViewModels
{
	public class ScorerViewModel
	{
		public int ShootId { get; set; }
		public int ShotId { get; set; }
		public int? PreviousShotId { get; set; }
		public int? NextShotId { get; set; }

		public bool Sighter { get; set; }
		public bool FinalSighter { get; set; }

		public int ShotNumber { get; set; }

		public Score? Score { get; set; }

		public int? RegisterCardId { get; set; }
		public int? TeamCompetitorId { get; set; }

		public string CompetitionName { get; set; }
		public string CompetitorName { get; set; }
		public Distance Distance { get; set; }
	}
}