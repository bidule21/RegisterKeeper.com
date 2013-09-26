using System;
using System.Linq;
using Coypu;

namespace RegisterKeeper.BrowserAutomationTests
{
	internal static class Extensions
	{
		internal static void EnsureLoggedIn(this BrowserSession browser)
		{
			var loggedIn = new State(() => browser.HasContent("Log off"));
			var loggedOut = new State(() => browser.HasContent("Login"));

			if (browser.FindState(loggedIn, loggedOut) == loggedIn) return;

			browser.ClickLink("Login");
			browser.ClickButton("Google");

			browser.FillIn("Email").With("registerkeepertestuser@gmail.com");
			browser.FillIn("Password").With(Environment.GetEnvironmentVariable("RegisterKeeperTestData"));

			browser.ClickButton("Sign in");

			if (browser.HasContent("Associate your Google account"))
			{
				browser.ClickButton("Register");
			}

			if (!browser.FindCss("div.navbar").HasContent("registerkeepertestuser@gmail.com"))
			{
				throw new Exception("Login process failed.");
			}
		}

		internal static SnapshotElementScope GetShootFormByDistance(this BrowserSession browser, string distance)
		{
			return browser.FindAllCss("div.shoot-form").Single(x => x.HasCss("label", "300yds"));
		}
	}
}
