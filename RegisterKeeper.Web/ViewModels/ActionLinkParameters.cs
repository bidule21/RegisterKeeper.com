namespace RegisterKeeper.Web.ViewModels
{
	public class ActionLinkParameters
	{
		public string LinkText { get; set; }
		public string ActionName { get; set; }
		public string ControllerName { get; set; }
		public object RouteValues { get; set; }
		public object HtmlAttributes { get; set; }
	}
}