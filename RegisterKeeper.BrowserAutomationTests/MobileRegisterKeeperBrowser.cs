using System;
using Coypu;
using NUnit.Framework;

namespace RegisterKeeper.BrowserAutomationTests
{
	public class MobileRegisterKeeperBrowser : BrowserSession
	{
		public MobileRegisterKeeperBrowser(SessionConfiguration sessionConfiguration)
			: base(sessionConfiguration)
		{
			ResizeTo(352, 579);
			Visit("/ViewSwitcher/SwitchView/?mobile=true");
		}

		public void EnsureLoggedIn()
		{
			ClickButton("Google");
			FillIn("Email").With("registerkeepertestuser@gmail.com");
			FillIn("Password").With(Environment.GetEnvironmentVariable("RegisterKeeperTestData"));
			ClickButton("Sign in");
		}

		public ElementScope ClickScorerButton(string score, string shotNumber)
		{
			// Check shot number is displayed otherwise Coypu goes too quickly
			// and the score is applied to the previous shot	
			Assert.That(HasCss(".scorer-shot-number", shotNumber, new Options { Timeout = TimeSpan.FromSeconds(5) }));

			//Thread.Sleep(500);
			var e = FindCss("input[type=button][value='" + score + "']", new Options { Timeout = TimeSpan.FromSeconds(5) }).Click();
			//Thread.Sleep(100);
			return e;
		}

		public ElementScope ClickNext()
		{
			//ClickLink("Next");
			return FindCss("a", "Next").Click();
		}
	}
}
