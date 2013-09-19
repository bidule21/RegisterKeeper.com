using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace RegisterKeeper.Web.External.MvcEnumFlags
{
	public static class CheckBoxesForEnumFlagsModelHtmlHelper
	{
		/// <summary>
		/// Creates checkboxes for flag enums.
		/// Based on implementation at http://stackoverflow.com/questions/9264927/model-bind-list-of-enum-flags.
		/// </summary>
		/// <typeparam name="TModel">Type of flag enum.</typeparam>
		/// <typeparam name="TEnum"></typeparam>
		/// <param name="htmlHelper">Html helper.</param>
		/// <param name="expression"></param>
		/// <returns></returns>
		public static IHtmlString CheckBoxesForEnumFlagsFor<TModel, TEnum>(
			this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TEnum>> expression)
		{
			var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
			var enumModelType = metadata.ModelType;

			// Check to make sure this is an enum.
			if (!enumModelType.IsEnum)
			{
				throw new ArgumentException("This helper can only be used with enums. Type used was: " + enumModelType.FullName + ".");
			}

			// Create string for Element.
			var sb = new StringBuilder();
			foreach (Enum item in Enum.GetValues(enumModelType))
			{
				if (Convert.ToInt32(item) == 0) continue;

				//var span = new TagBuilder("span");
				//span.Attributes.Add("class", "checkbox-label-pair");
				//sb.AppendLine(span.ToString(TagRenderMode.StartTag));

				var templateInfo = htmlHelper.ViewData.TemplateInfo;
				var id = templateInfo.GetFullHtmlFieldId(item.ToString());
				var name = templateInfo.GetFullHtmlFieldName(metadata.PropertyName);
				
				var label = new TagBuilder("label");
				label.Attributes["for"] = id;
				var field = item.GetType().GetField(item.ToString());

				// Add checkbox.
				var checkbox = new TagBuilder("input");
				checkbox.Attributes["id"] = id;
				checkbox.Attributes["name"] = name;
				checkbox.Attributes["type"] = "checkbox";
				checkbox.Attributes["value"] = item.ToString();
				
				var model = metadata.Model as Enum;
				if ((model != null) && (model.HasFlag(item)))
				{
					checkbox.Attributes["checked"] = "checked";
				}
				sb.AppendLine(checkbox.ToString());

				// Check to see if DisplayName attribute has been set for item.
				var displayName = field.GetCustomAttributes(typeof(DisplayNameAttribute), true)
									   .FirstOrDefault() as DisplayNameAttribute;
				if (displayName != null)
				{
					// Display name specified.  Use it.
					label.SetInnerText(displayName.DisplayName);
				}
				else
				{
					// Check to see if Display attribute has been set for item.
					var display = field.GetCustomAttributes(typeof(DisplayAttribute), true)
									   .FirstOrDefault() as DisplayAttribute;
					label.SetInnerText(display != null ? display.Name : item.ToString());
				}
				sb.AppendLine(label.ToString());

				// Add line break.
				//sb.AppendLine("<br />");
				
				//sb.AppendLine(span.ToString(TagRenderMode.EndTag));
			}

			return new HtmlString(sb.ToString());
		}
	}
}
