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
					Port = 50891
				};
			}

		}

		internal static string DateFormat { get { return "dd MMMM yyyy HH:mm"; } }
	}
}
