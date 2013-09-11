using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web
{
	public static class HtmlHelpers
	{
		public static MvcHtmlString DisplayFor(this HtmlHelper helper, Distance distances)
		{
			return new MvcHtmlString(distances.DisplayValue());
		}
	}
}