using System;
using System.Linq;
using Coypu.Matchers;
using NUnit.Framework;

namespace RegisterKeeper.BrowserAutomationTests
{
	[TestFixture]
	public class IndividualCompetitionTests : TestBase
	{
		[Test]
		public void _0010_AddIndividualCompetition()
		{
			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.ClickLink("Add Competition");
			Browser.ClickLink("Add Individual Competition");

			var now = DateTime.Now;
			const string dateFormat = "dd MMMM yyyy HH:mm";

			Browser.FillIn("Name").With("Test Individual Competition");
			Browser.FillIn("Start date & time").With(now.ToString(dateFormat));
			Browser.FillIn("End date & time").With(now.AddHours(1).ToString(dateFormat));
			Browser.Check("300yds");
			Browser.FillIn("Location").With("Century Range, Bisley");
			Browser.FillIn("Number of Sighting Shots").With("2");
			Browser.FillIn("Number of Scoring Shots").With("10");

			Browser.ClickButton("Create");

			Assert.That(Browser, Shows.Css("h2", "Test Individual Competition"));
			Assert.IsTrue(Browser.Has(Browser.FindLink("Add Register Card")));
		}

		[Test]
		public void _0020_EditIndividualCompetition()
		{
			Browser.Visit("/");
			Browser.FindCss("h4", "Test Individual Competition").Click();
			Browser.ClickLink("Edit Competition");

			Browser.FillIn("Name").With("Test Individual Competition Edited");
			Browser.ClickButton("Save");

			Assert.That(Browser, Shows.Css("h2", "Test Individual Competition Edited"));
		}

		[Test]
		public void _0030_AddRegisterCard()
		{
			Browser.Visit("/");
			Browser.FindCss("h4", "Test Individual Competition Edited").Click();
			Browser.ClickLink("Add Register Card");
			Browser.FillIn("Competitor Name").With("Test Competitor");
			Browser.FillIn("Index Number").With("123");
			Browser.FillIn("Class").With("X");
			Browser.FillIn("Club").With("Test Club");

			var x300YdsShoot = Browser.GetShootFormByDistance("300yds");
			x300YdsShoot.FillIn("S1").With("V");
			x300YdsShoot.FillIn("S2").With("4");
			x300YdsShoot.FillIn("1").With("5");
			x300YdsShoot.FillIn("2").With("5");
			x300YdsShoot.FillIn("3").With("V");
			x300YdsShoot.FillIn("4").With("V");
			x300YdsShoot.FillIn("5").With("4");
			x300YdsShoot.FillIn("6").With("3");
			x300YdsShoot.FillIn("7").With("4");
			x300YdsShoot.FillIn("8").With("5");
			x300YdsShoot.FillIn("9").With("V");
			x300YdsShoot.FillIn("10").With("V");
			// 46.4

			Browser.ClickButton("Create");

			Assert.That(
				Browser.FindAllCss(".register-card-container")
				.Count(x =>
					x.HasContent("Test Competitor")
					&& x.HasContent("123") // Index Number
					&& x.HasContent("X")
					&& x.HasContent("Test Club")
					&& x.HasContent("46.4v") // Total score
				) == 1);
		}

		[Test]
		public void _0040_EditRegisterCard()
		{
			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.FindCss("h4", "Test Individual Competition Edited").Click();
			Browser.FindAllCss(".register-card-container")
				   .Single(x => x.HasContent("Test Competitor"))
				   .ClickLink("Edit");

			Browser.FillIn("Competitor Name").With("Test Competitor Edited");
			Browser.FillIn("Index Number").With("456");
			Browser.FillIn("Class").With("A");
			Browser.FillIn("Club").With("Test Club Edited");

			var x300YdsShoot = Browser.GetShootFormByDistance("300yds");
			x300YdsShoot.FillIn("6").With("V");

			Browser.ClickButton("Save");

			Assert.That(
				Browser.FindAllCss(".register-card-container")
				.Count(x =>
					x.HasContent("Test Competitor Edited")
					&& x.HasContent("456") // Index Number
					&& x.HasContent("A")
					&& x.HasContent("Test Club Edited")
					&& x.HasContent("48.5v") // Total score
				) == 1);
		}
	}
}
