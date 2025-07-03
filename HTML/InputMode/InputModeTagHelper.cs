using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

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
            if (For?.Metadata?.AdditionalValues.TryGetValue("InputMode", out var inputModeValue) == true)
            {
                output.Attributes.SetAttribute("inputmode", inputModeValue?.ToString());
            }
        }
    }
}