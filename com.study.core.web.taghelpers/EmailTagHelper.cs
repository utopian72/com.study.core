using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace com.study.core.web.taghelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "contoso.com";
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Content.SetContent(address);
        }
    }
}
