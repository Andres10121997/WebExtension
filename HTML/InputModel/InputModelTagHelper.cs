using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Reflection;

namespace WebExtension.HTML.InputModel
{
    [
        HtmlTargetElement(
            "input",
            Attributes = ForAttributeName
        )
    ]
    public class InputModelTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var property = For?.Metadata?.ContainerType?.GetProperty(For?.Name);
            if (property == null) return;

            var attr = property.GetCustomAttribute<InputModelAttribute>();
            if (attr != null)
            {
                output.Attributes.SetAttribute("inputmode", attr.InputMode.ToString());
            }
        }
    }
}