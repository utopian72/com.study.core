#pragma checksum "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f286e91331986a31bce1e11d9aedd964e4c82998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblSurveys_Index), @"mvc.1.0.view", @"/Views/TblSurveys/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TblSurveys/Index.cshtml", typeof(AspNetCore.Views_TblSurveys_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#line 1 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\_ViewImports.cshtml"
using com.study.core.web;

#line default
#line hidden
#line 2 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\_ViewImports.cshtml"
using com.study.core.web.Models;

#line default
#line hidden
#line 1 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#line 2 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#line 3 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using System.Web;

#line default
#line hidden
#line 5 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using com.study.core.model;

#line default
#line hidden
#line 6 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using com.study.core.web.Pagination;

#line default
#line hidden
#line 7 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using PagedList.Core;

#line default
#line hidden
#line 9 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f286e91331986a31bce1e11d9aedd964e4c82998", @"/Views/TblSurveys/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1b9a41f2cdc78c678473acbde6fecc50a11cac", @"/Views/_ViewImports.cshtml")]
    public class Views_TblSurveys_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<TblSurvey>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TblSurveys", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(237, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(332, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(389, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(420, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
  
    ViewData["Title"] = "조사 목록";
    Layout = "~/Views/Shared/_Layout.cshtml";

    int page = Model.PageNumber;

    string currentSort = string.IsNullOrWhiteSpace(ViewData["currentSort"].ToString()) ? "SName" : ViewData["currentSort"].ToString();
    string query = string.IsNullOrWhiteSpace(ViewData["query"].ToString()) ? "" : ViewData["query"].ToString();


    

#line default
#line hidden
            BeginContext(807, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f286e91331986a31bce1e11d9aedd964e4c829988225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(858, 636, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {

        $("".button-download"").click(function(){

            alert(""ddd"");
        })
    });

</script>
<style>
    .header-survey-title {
        width:450px;
    }

    .header-survey-active {
        width: 100px;
    }

    .header-survey-quota {
        width: 80px;
    }

    .header-survey-lastday {
        width: 80px;
    }

    .header-survey-year {
        width: 100px;
    }

    .header-survey-button {
        width: 100px;
    }


    .column-text-center {
        text-align: center;
    }
</style>

<h1>");
            EndContext();
            BeginContext(1495, 17, false);
#line 73 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 52, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"text-right\">\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(1564, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f286e91331986a31bce1e11d9aedd964e4c8299810432", async() => {
                BeginContext(1646, 2, true);
                WriteLiteral("등록");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1652, 30, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 85 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
 using (Html.BeginForm("Index", "TblSurveys", new { page = page, sortOrder = "SName" }, FormMethod.Get))
{

#line default
#line hidden
            BeginContext(1791, 168, true);
            WriteLiteral("    <div class=\"input-group mb-3\">\r\n        <input type=\"text\" name=\"query\" class=\"form-control btn-\" placeholder=\"조사명\" aria-label=\"조사명\" aria-describedby=\"basic-addon2\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1959, "\"", 1973, 1);
#line 88 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
WriteAttributeValue("", 1967, query, 1967, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1974, 239, true);
            WriteLiteral(">\r\n        <div class=\"input-group-append\">\r\n            <button class=\"btn btn-outline-secondary\" type=\"submit\">검색</button>\r\n            <button class=\"btn btn-outline-secondary button-download\" type=\"button\">다운로드</button>\r\n\r\n            ");
            EndContext();
            BeginContext(2214, 105, false);
#line 93 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
       Write(Html.ActionLink("다운로드", "Download", "TblSurveys", new { query = query }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 96 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2352, 139, true);
            WriteLiteral("<table class=\"table table-hover table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"header-survey-title\">\r\n                ");
            EndContext();
            BeginContext(2491, 247, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f286e91331986a31bce1e11d9aedd964e4c8299814151", async() => {
                BeginContext(2626, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2649, 67, false);
#line 102 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().SName));

#line default
#line hidden
                EndContext();
                BeginContext(2716, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
                                                                      WriteLiteral(Model.PageNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 101 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
                                                                                                              WriteLiteral(ViewData["sortOrderSName"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2738, 85, true);
            WriteLiteral("\r\n            </th>\r\n            <th  class=\"header-survey-active\">\r\n                ");
            EndContext();
            BeginContext(2824, 67, false);
#line 106 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().UseBl));

#line default
#line hidden
            EndContext();
            BeginContext(2891, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(2967, 72, false);
#line 109 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().SmsMessage));

#line default
#line hidden
            EndContext();
            BeginContext(3039, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"header-survey-quota\">\r\n                ");
            EndContext();
            BeginContext(3123, 72, false);
#line 112 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().IngQuotaBl));

#line default
#line hidden
            EndContext();
            BeginContext(3195, 85, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"header-survey-lastday\">\r\n                ");
            EndContext();
            BeginContext(3281, 69, false);
#line 115 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().LastDay));

#line default
#line hidden
            EndContext();
            BeginContext(3350, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(3426, 70, false);
#line 118 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().Callback));

#line default
#line hidden
            EndContext();
            BeginContext(3496, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3552, 65, false);
#line 121 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().Url));

#line default
#line hidden
            EndContext();
            BeginContext(3617, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(3693, 73, false);
#line 124 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().Description));

#line default
#line hidden
            EndContext();
            BeginContext(3766, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(3842, 70, false);
#line 127 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().LogoFile));

#line default
#line hidden
            EndContext();
            BeginContext(3912, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(3988, 76, false);
#line 130 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().UseListCountBl));

#line default
#line hidden
            EndContext();
            BeginContext(4064, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(4140, 74, false);
#line 133 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().CssStyleName));

#line default
#line hidden
            EndContext();
            BeginContext(4214, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(4290, 78, false);
#line 136 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().UseQuotaAccessBl));

#line default
#line hidden
            EndContext();
            BeginContext(4368, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(4444, 71, false);
#line 139 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().LogoWidth));

#line default
#line hidden
            EndContext();
            BeginContext(4515, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"column_hide\">\r\n                ");
            EndContext();
            BeginContext(4591, 71, false);
#line 142 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().LogHeight));

#line default
#line hidden
            EndContext();
            BeginContext(4662, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"header-survey-year\">\r\n                ");
            EndContext();
            BeginContext(4745, 72, false);
#line 145 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToList().FirstOrDefault().SurveyYear));

#line default
#line hidden
            EndContext();
            BeginContext(4817, 119, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"header-survey-button\">수정</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 152 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(4985, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5046, 82, false);
#line 156 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.ActionLink(item.SName, "Index", "TblLists", new { surveyno = item.SurveyNo }));

#line default
#line hidden
            EndContext();
            BeginContext(5128, 94, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column-text-center\">\r\n                    ");
            EndContext();
            BeginContext(5223, 40, false);
#line 159 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UseBl));

#line default
#line hidden
            EndContext();
            BeginContext(5263, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(5351, 45, false);
#line 162 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SmsMessage));

#line default
#line hidden
            EndContext();
            BeginContext(5396, 95, true);
            WriteLiteral("\r\n                </td>\r\n                <td  class=\"column-text-center\">\r\n                    ");
            EndContext();
            BeginContext(5492, 45, false);
#line 165 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IngQuotaBl));

#line default
#line hidden
            EndContext();
            BeginContext(5537, 94, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column-text-center\">\r\n                    ");
            EndContext();
            BeginContext(5632, 42, false);
#line 168 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastDay));

#line default
#line hidden
            EndContext();
            BeginContext(5674, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(5762, 43, false);
#line 171 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Callback));

#line default
#line hidden
            EndContext();
            BeginContext(5805, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5873, 38, false);
#line 174 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
            EndContext();
            BeginContext(5911, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(5999, 46, false);
#line 177 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(6045, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(6133, 43, false);
#line 180 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LogoFile));

#line default
#line hidden
            EndContext();
            BeginContext(6176, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(6264, 49, false);
#line 183 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UseListCountBl));

#line default
#line hidden
            EndContext();
            BeginContext(6313, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(6401, 47, false);
#line 186 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CssStyleName));

#line default
#line hidden
            EndContext();
            BeginContext(6448, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(6536, 51, false);
#line 189 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UseQuotaAccessBl));

#line default
#line hidden
            EndContext();
            BeginContext(6587, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(6675, 44, false);
#line 192 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LogoWidth));

#line default
#line hidden
            EndContext();
            BeginContext(6719, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column_hide\">\r\n                    ");
            EndContext();
            BeginContext(6807, 44, false);
#line 195 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LogHeight));

#line default
#line hidden
            EndContext();
            BeginContext(6851, 94, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"column-text-center\">\r\n                    ");
            EndContext();
            BeginContext(6946, 45, false);
#line 198 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SurveyYear));

#line default
#line hidden
            EndContext();
            BeginContext(6991, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7058, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f286e91331986a31bce1e11d9aedd964e4c8299832098", async() => {
                BeginContext(7133, 2, true);
                WriteLiteral("수정");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 201 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
                                                                   WriteLiteral(item.SurveyNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7139, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 205 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(7196, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
            BeginContext(7224, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f286e91331986a31bce1e11d9aedd964e4c8299834873", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 210 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 210 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = SitePagedListRenderOptions.Boostrap4;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 210 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
                                                                                                      WriteLiteral(currentSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#line 210 "G:\GitHub\utopian72\com.study.core\com.study.core.web\Views\TblSurveys\Index.cshtml"
                                                                                                                                                                                    WriteLiteral(query);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7426, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<TblSurvey>> Html { get; private set; }
    }
}
#pragma warning restore 1591