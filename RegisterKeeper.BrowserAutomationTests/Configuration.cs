using System;
using Coypu;

namespace RegisterKeeper.BrowserAutomationTests
{
	static class Configuration
	{
		internal static SessionConfiguration SessionConfiguration
		{
			get
			{
				return new SessionConfiguration
				{
					//AppHost = "www.registerkeeper.com"
					Port = 50891,
					Timeout = TimeSpan.FromSeconds(5)
				};
			}

		}

		internal static string CompetitionDateFormat { get { return "dd MMMM yyyy HH:mm"; } }
	}
}
