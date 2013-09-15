using System.Web.Optimization;

namespace RegisterKeeper.Web
{
	public class BundleMobileConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{

			bundles.Add(new ScriptBundle("~/bundles/jquerymobile")
				.Include("~/Scripts/jquery.mobile-{version}.js"));

			bundles.Add(new StyleBundle("~/Content/jquery-mobile-css")
				.Include("~/Content/jquery.mobile-{version}.css"));

			bundles.Add(new StyleBundle("~/Content/Mobile/css")
				.Include("~/Content/RegisterKeeper.Mobile.css"));
		}
	}
}