using Coypu;
using NUnit.Framework;

namespace RegisterKeeper.BrowserAutomationTests
{
	public abstract class TestBase
	{
		protected BrowserSession Browser;

		#region TestFixtureSetUp

		[TestFixtureSetUp]
		public void Setup()
		{
			Browser = new BrowserSession(Configuration.SessionConfiguration);
			Browser.MaximiseWindow();
		}

		[TestFixtureTearDown]
		public void Dispose()
		{
			Browser.Dispose();
		}

		#endregion

		
	}
}
