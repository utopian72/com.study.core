#pragma checksum "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b518e889ae162a1069624f80f5b27ef94b19d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblLists_Details), @"mvc.1.0.view", @"/Views/TblLists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TblLists/Details.cshtml", typeof(AspNetCore.Views_TblLists_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\_ViewImports.cshtml"
using com.study.core.web;

#line default
#line hidden
#line 2 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\_ViewImports.cshtml"
using com.study.core.web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b518e889ae162a1069624f80f5b27ef94b19d2", @"/Views/TblLists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1b9a41f2cdc78c678473acbde6fecc50a11cac", @"/Views/_ViewImports.cshtml")]
    public class Views_TblLists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<com.study.core.model.TblList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TblList</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(260, 43, false);
#line 15 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CellNum));

#line default
#line hidden
            EndContext();
            BeginContext(303, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(367, 39, false);
#line 18 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.CellNum));

#line default
#line hidden
            EndContext();
            BeginContext(406, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(469, 44, false);
#line 21 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FinishBl));

#line default
#line hidden
            EndContext();
            BeginContext(513, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(577, 40, false);
#line 24 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.FinishBl));

#line default
#line hidden
            EndContext();
            BeginContext(617, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(680, 41, false);
#line 27 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IngBl));

#line default
#line hidden
            EndContext();
            BeginContext(721, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(785, 37, false);
#line 30 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.IngBl));

#line default
#line hidden
            EndContext();
            BeginContext(822, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(885, 45, false);
#line 33 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RefusalBl));

#line default
#line hidden
            EndContext();
            BeginContext(930, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(994, 41, false);
#line 36 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.RefusalBl));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1098, 47, false);
#line 39 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuotaOverBl));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1209, 43, false);
#line 42 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuotaOverBl));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1315, 42, false);
#line 45 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StopBl));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1421, 38, false);
#line 48 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.StopBl));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1522, 43, false);
#line 51 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndCode));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1629, 39, false);
#line 54 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndCode));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1731, 45, false);
#line 57 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StateCode));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1840, 41, false);
#line 60 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.StateCode));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1944, 41, false);
#line 63 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Col01));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2049, 37, false);
#line 66 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Col01));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2149, 41, false);
#line 69 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Col02));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2254, 37, false);
#line 72 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Col02));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2354, 41, false);
#line 75 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Col03));

#line default
#line hidden
            EndContext();
            BeginContext(2395, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2459, 37, false);
#line 78 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Col03));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2559, 41, false);
#line 81 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Col04));

#line default
#line hidden
            EndContext();
            BeginContext(2600, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2664, 37, false);
#line 84 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Col04));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2764, 41, false);
#line 87 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Col05));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2869, 37, false);
#line 90 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Col05));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2969, 41, false);
#line 93 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Col06));

#line default
#line hidden
            EndContext();
            BeginContext(3010, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3074, 37, false);
#line 96 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Col06));

#line default
#line hidden
            EndContext();
            BeginContext(3111, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3174, 46, false);
#line 99 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestCount));

#line default
#line hidden
            EndContext();
            BeginContext(3220, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3284, 42, false);
#line 102 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuestCount));

#line default
#line hidden
            EndContext();
            BeginContext(3326, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3389, 54, false);
#line 105 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyNoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3443, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3507, 61, false);
#line 108 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyNoNavigation.SmsMessage));

#line default
#line hidden
            EndContext();
            BeginContext(3568, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3616, 68, false);
#line 113 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblLists\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3684, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3692, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b518e889ae162a1069624f80f5b27ef94b19d218080", async() => {
                BeginContext(3714, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3730, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration TelemetryConfiguration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<com.study.core.model.TblList> Html { get; private set; }
    }
}
#pragma warning restore 1591
