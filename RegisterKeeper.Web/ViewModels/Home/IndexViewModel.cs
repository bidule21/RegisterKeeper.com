using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.ViewModels.Home
{
	public class IndexViewModel
	{
		public List<Competition> LiveCompetitions { get; set; }
		public List<Competition> UpcomingCompetitions { get; set; }
		public List<Competition> CompletedCompetitions { get; set; }
	}
}