using System.Collections.Generic;
using System.Text;
using System.Web;
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

		#region Script file in templates helpers - Adapted code from https://bitbucket.org/forloop/forloop-htmlhelpers

		class ScriptContext
		{
			internal const string ScriptContextItem = "ScriptContext";
			private readonly HashSet<string> _scriptFiles = new HashSet<string>();

			public HashSet<string> ScriptFiles
			{
				get { return _scriptFiles; }
			}
		}

		public static void AddScriptFile(this HtmlHelper htmlHelper, string path)
		{
			var scriptContext =
				htmlHelper.ViewContext.HttpContext.Items[ScriptContext.ScriptContextItem] as ScriptContext;

			if (scriptContext == null)
			{
				scriptContext = new ScriptContext();
				htmlHelper.ViewContext.HttpContext.Items[ScriptContext.ScriptContextItem] = scriptContext;
			}

			if (!scriptContext.ScriptFiles.Contains(path))
			{
				scriptContext.ScriptFiles.Add(path);
			}

		}

		public static IHtmlString RenderScripts(this HtmlHelper htmlHelper)
		{
			var scriptContext =
				htmlHelper.ViewContext.HttpContext.Items[ScriptContext.ScriptContextItem] as ScriptContext;

			if (scriptContext != null)
			{
				var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext, htmlHelper.RouteCollection);
				var stringBuilder = new StringBuilder(scriptContext.ScriptFiles.Count);
				foreach (var scriptFile in scriptContext.ScriptFiles)
				{
					stringBuilder.AppendLine("<script src='" +
										   urlHelper.Content(scriptFile) +
										   "'></script>");
				}

				return new HtmlString(stringBuilder.ToString());
			}

			return MvcHtmlString.Empty;

		}

		#endregion

	}
}