using System;
using System.Linq;
using NUnit.Framework;

namespace RegisterKeeper.BrowserAutomationTests
{
	[TestFixture]
	public class TeamCompetitionTests : TestBase
	{
		[Test]
		public void _0010_AddTeamCompetition()
		{
			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.ClickLink("Add Competition");
			Browser.ClickLink("Add Team Competition");

			var now = DateTime.Now;

			Browser.FillIn("Name").With("Test Team Competition");
			Browser.FillIn("Start date & time").With(now.ToString(Configuration.DateFormat));
			Browser.FillIn("End date & time").With(now.AddHours(1).ToString(Configuration.DateFormat));
			Browser.Check("300yds");
			Browser.FillIn("Location").With("Century Range, Bisley");
			Browser.FillIn("Number of Sighting Shots").With("2");
			Browser.FillIn("Number of Scoring Shots").With("10");

			Browser.ClickButton("Create");

			Assert.IsTrue(Browser.FindCss("h2").HasContent("Test Team Competition"),
				"Competition name not found not found.");

			Assert.IsTrue(Browser.Has(Browser.FindLink("Add Team Register Card")));
		}

		[Test]
		public void _0020_EditTeamCompetition()
		{
			Browser.Visit("/");
			Browser.FindCss("h4", "Test Team Competition").Click();
			Browser.ClickLink("Edit Competition");

			Browser.FillIn("Name").With("Test Team Competition Edited");
			var now = DateTime.Now;
			Browser.FillIn("Start date & time").With(now.ToString(Configuration.DateFormat));
			Browser.FillIn("End date & time").With(now.AddHours(1).ToString(Configuration.DateFormat));
			Browser.FillIn("Location").With("Test Location Edited");
			Browser.ClickButton("Save");

			Assert.That(Browser.HasCss("h2", "Test Team Competition Edited"));
		}

		[Test]
		public void _0030_AddTeamRegisterCard()
		{
			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.FindCss("h4", "Test Team Competition Edited").Click();
			Browser.ClickLink("Add Team Register Card");
			Browser.FillIn("Team Name").With("Test Team");
			Browser.FillIn("Team Captain").With("Test Captain");
			Browser.ClickButton("Save");

			Assert.That(
				Browser.FindAllCss(".register-card-container")
				.Count(x => x.HasContent("Test Team"))
				 == 1
			);
		}

		[Test]
		public void _0040_EditTeamRegisterCard()
		{
			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.FindCss("h4", "Test Team Competition Edited").Click();
			Browser.FindAllCss(".register-card-container")
				   .Single(x => x.HasContent("Test Team"))
				   .ClickLink("Edit");

			Browser.FillIn("Team Name").With("Test Team Edited");
			Browser.FillIn("Team Captain").With("Test Captain Edited");
			Browser.ClickButton("Save");

			Assert.That(
				Browser.FindAllCss(".register-card-container")
				.Count(x => x.HasContent("Test Team Edited"))
				 == 1
			);
		}

		[Test]
		public void _0050_AddCompetitorToTeamRegisterCard()
		{
			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.FindCss("h4", "Test Team Competition Edited").Click();
			Browser.FindAllCss(".register-card-container")
				   .Single(x => x.HasContent("Test Team Edited"))
				   .ClickLink("Add Competitor");

			Browser.FillIn("Competitor Name").With("Test Competitor");
			Browser.FillIn("S1").With("5");
			Browser.FillIn("S2").With("V");
			Browser.Check("S1 Converted");
			Browser.Check("S2 Converted");
			Browser.FillIn("1").With("5");
			Browser.FillIn("2").With("V");
			Browser.FillIn("3").With("3");
			Browser.FillIn("4").With("4");
			Browser.FillIn("5").With("5");
			Browser.FillIn("6").With("1");
			Browser.FillIn("7").With("2");
			Browser.FillIn("8").With("3");
			Browser.FillIn("9").With("4");
			Browser.FillIn("10").With("5");

			Browser.ClickButton("Save");

			var registerCard = Browser.FindAllCss(".register-card-container")
									  .Single(rc => rc.HasContent("Test Team Edited"));
			Assert.That(registerCard.FindAllCss("tr")
									.Count(row =>
										   row.HasContent("Test Competitor")
										   && row.HasContent("37.1v"))
						== 1);
		}
	}
}
