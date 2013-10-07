using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Coypu;
using NUnit.Framework;

namespace RegisterKeeper.BrowserAutomationTests.Combined
{
	[TestFixture]
	public class IndividualCompetitionTests : TestBase
	{

		//private class Competitor
		//{
		//	public string CompetitorName { get; set; }
		//	public int IndexNumber { get; set; }
		//	public string Class { get; set; }
		//	public string Club { get; set; }
		//}

		[Test]
		public void TheTimes2013()
		{
			DontDispose = true;

			Browser.Visit("/");
			Browser.EnsureLoggedIn();

			Browser.ClickLink("Add Competition");
			Browser.ClickLink("Add Individual Competition");

			var now = DateTime.Now;

			Browser.FillIn("Name").With("Times");
			Browser.FillIn("Start date & time").With(now.ToString(Configuration.CompetitionDateFormat));
			Browser.FillIn("End date & time").With(now.AddHours(4).ToString(Configuration.CompetitionDateFormat));
			Browser.Check("300yds");
			Browser.FillIn("Location").With("Century Range, Bisley");
			Browser.FillIn("Number of Sighting Shots").With("2");
			Browser.FillIn("Number of Scoring Shots").With("10");

			Browser.ClickButton("Create");

			var blake = Task.Factory.StartNew(() =>
				{
					var mobile = new MobileRegisterKeeperBrowser(Configuration.SessionConfiguration);
					mobile.ClickLink("Times");
					mobile.FindCss("span", "Add Register Card").Click();

					mobile.EnsureLoggedIn();

					mobile.FillIn("Competitor Name").With("Mr D Blake");
					//mobile.FillIn("Index Number").With("");
					mobile.FillIn("Class").With("X");
					mobile.FillIn("Club").With("LMRA");

					// Can't use ClickButton as it finds a div created by jQuery Mobile instead of the actual button
					mobile.FindCss("input[type=submit]").Click();

					mobile.FindCss("a", new Regex("300yds.*")).Click();
					mobile.ClickScorerButton("0", "S1");
					mobile.ClickNext();
					mobile.ClickScorerButton("0", "S2");
					mobile.ClickNext();

					mobile.ClickLink("Convert None", new Options { Timeout = TimeSpan.FromSeconds(5) });

					mobile.ClickScorerButton("V", "1");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "2");
					mobile.ClickNext();
					mobile.ClickScorerButton("5", "3");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "4");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "5");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "6");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "7");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "8");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "9");
					mobile.ClickNext();
					mobile.ClickScorerButton("V", "10");
					mobile.ClickNext();

					Assert.That(mobile.HasContent("50.9v"), "Final score for Blake did not equal 50.9v.");

					if (!DontDispose)
					{
						mobile.Dispose();
					}

				});

			var nuthall = Task.Factory.StartNew(() =>
			{
				var mobile = new MobileRegisterKeeperBrowser(Configuration.SessionConfiguration);
				mobile.ClickLink("Times");
				mobile.FindCss("span", "Add Register Card").Click();

				mobile.EnsureLoggedIn();

				mobile.FillIn("Competitor Name").With("Mr DE Nuthall");
				//mobile.FillIn("Index Number").With("");
				mobile.FillIn("Class").With("X");
				mobile.FillIn("Club").With("Old Epsomian RC");

				// Can't use ClickButton as it finds a div created by jQuery Mobile instead of the actual button
				mobile.FindCss("input[type=submit]").Click();

				mobile.FindCss("a", new Regex("300yds.*")).Click();
				mobile.ClickScorerButton("0", "S1");
				mobile.ClickNext();
				mobile.ClickScorerButton("0", "S2");
				mobile.ClickNext();

				mobile.ClickLink("Convert None", new Options { Timeout = TimeSpan.FromSeconds(5) });

				mobile.ClickScorerButton("V", "1");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "2");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "3");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "4");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "5");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "6");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "7");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "8");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "9");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "10");
				mobile.ClickNext();

				Assert.That(mobile.HasContent("50.10v"), "Final score for Nuthall did not equal 50.10v.");

				if (!DontDispose)
				{
					mobile.Dispose();
				}

			});

			var haasbroek = Task.Factory.StartNew(() =>
			{
				var mobile = new MobileRegisterKeeperBrowser(Configuration.SessionConfiguration);
				mobile.ClickLink("Times");
				mobile.FindCss("span", "Add Register Card").Click();

				mobile.EnsureLoggedIn();

				mobile.FillIn("Competitor Name").With("Mr PA Haasbroek");
				//mobile.FillIn("Index Number").With("");
				mobile.FillIn("Class").With("X");
				mobile.FillIn("Club").With("Witwatersrand");

				// Can't use ClickButton as it finds a div created by jQuery Mobile instead of the actual button
				mobile.FindCss("input[type=submit]").Click();

				mobile.FindCss("a", new Regex("300yds.*")).Click();
				mobile.ClickScorerButton("0", "S1");
				mobile.ClickNext();
				mobile.ClickScorerButton("0", "S2");
				mobile.ClickNext();

				mobile.ClickLink("Convert None", new Options { Timeout = TimeSpan.FromSeconds(5) });

				mobile.ClickScorerButton("V", "1");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "2");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "3");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "4");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "5");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "6");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "7");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "8");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "9");
				mobile.ClickNext();
				mobile.ClickScorerButton("V", "10");
				mobile.ClickNext();

				Assert.That(mobile.HasContent("50.10v", new Options { Timeout = TimeSpan.FromSeconds(5) }),
					"Final score for Haasbroek did not equal 50.10v.");

				if (!DontDispose)
				{
					mobile.Dispose();
				}

			});

			Task.WaitAll(blake, nuthall, haasbroek);

			// Tie shoot..

			//Browser.ClickLink("Delete Competition");
			//Browser.ClickButton("Delete");


		}
	}
}
