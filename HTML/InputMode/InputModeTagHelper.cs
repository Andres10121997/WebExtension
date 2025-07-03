using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Reflection;

namespace WebExtension.HTML.InputMode
{
    [
        HtmlTargetElement(
            "input",
            Attributes = ForAttributeName
        )
    ]
    public class InputModeTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var property = For?.Metadata?.ContainerType?.GetProperty(For?.Name);
            if (property == null) return;

            var attr = property.GetCustomAttribute<InputModeAttribute>();
            if (attr != null)
            {
                output.Attributes.SetAttribute("inputmode", attr.InputMode.ToString());
            }
        }
    }
}