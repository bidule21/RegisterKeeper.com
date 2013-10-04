using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;
using NUnit.Framework;

namespace RegisterKeeper.BrowserAutomationTests
{
	[TestFixture]
	public class Demonstration : TestBase
	{

		private class Competitor
		{
			public string CompetitorName { get; set; }
			public int IndexNumber { get; set; }
			public string Class { get; set; }
			public string Club { get; set; }
		}

		[Test]
		public void RunDemonstration()
		{
			var competitors = new List<Competitor>
				{
					new Competitor
						{
							CompetitorName = "Competitor A",
							IndexNumber = 123,
							Class = "A",
							Club = "Club A"
						},
					//new Competitor
					//	{
					//		CompetitorName = "Competitor B",
					//		IndexNumber = 456,
					//		Class = "X",
					//		Club = "Club B"
					//	},
					//new Competitor
					//	{
					//		CompetitorName = "Competitor C",
					//		IndexNumber = 789,
					//		Class = "O",
					//		Club = "Club C"
					//	}
				};


			//Browser.Visit("/");
			//Browser.EnsureLoggedIn();

			//Browser.ClickLink("Add Competition");
			//Browser.ClickLink("Add Individual Competition");

			//var now = DateTime.Now;
			//const string dateFormat = "dd MMMM yyyy HH:mm";

			//Browser.FillIn("Name").With("Demo Individual Competition");
			//Browser.FillIn("Start date & time").With(now.ToString(dateFormat));
			//Browser.FillIn("End date & time").With(now.AddHours(1).ToString(dateFormat));
			//Browser.Check("300yds");
			//Browser.FillIn("Location").With("Century Range, Bisley");
			//Browser.FillIn("Number of Sighting Shots").With("2");
			//Browser.FillIn("Number of Scoring Shots").With("10");

			//Browser.ClickButton("Create");

			competitors.AsParallel().ForAll(competitor =>
				{
					var mobile = new BrowserSession(Configuration.SessionConfiguration);
					mobile.ResizeTo(352, 579);

					mobile.Visit("/ViewSwitcher/SwitchView/?mobile=true&returnUrl=/");
					mobile.ClickLink("Demo Individual Competition");
					mobile.FindCss("span", "Add Register Card").Click();

					// Log in
					mobile.ClickButton("Google");
					mobile.FillIn("Email").With("registerkeepertestuser@gmail.com");
					mobile.FillIn("Password").With(Environment.GetEnvironmentVariable("RegisterKeeperTestData"));

					mobile.ClickButton("Sign in");

					mobile.FillIn("Competitor Name").With(competitor.CompetitorName);
					mobile.FillIn("Index Number").With(competitor.IndexNumber.ToString(CultureInfo.InvariantCulture));
					mobile.FillIn("Class").With(competitor.Class);
					mobile.FillIn("Club").With(competitor.Club);

					// Can't use ClickButton as it finds a div created by jQuery Mobile instead of the actual button
					mobile.FindCss("input[type=submit]").Click();

					mobile.ClickLink("");

					mobile.Dispose();
				});



		}
	}
}
