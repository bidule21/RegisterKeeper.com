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

		public bool DontDispose { get; set; }

		[TestFixtureTearDown]
		public void Dispose()
		{
			if (!DontDispose)
			{
				Browser.Dispose();
			}
		}

		#endregion

		
	}
}
