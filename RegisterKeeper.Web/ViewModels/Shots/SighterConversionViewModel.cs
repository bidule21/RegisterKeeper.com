using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.ViewModels
{
	public class SighterConversionViewModel
	{
		public int ShootId { get; set; }

		public string CompetitionName { get; set; }
		public string CompetitorName { get; set; }
		public Distance Distance { get; set; }

		public List<SightingShot> SightingShots { get; set; }
		public int NextShotId { get; set; }
	}
}