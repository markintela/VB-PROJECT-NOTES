#pragma checksum "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05289bc10bfcbface2328696cae52358bd575074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_Index), @"mvc.1.0.view", @"/Views/Country/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\_ViewImports.cshtml"
using VB_PROJECTS_NOTES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\_ViewImports.cshtml"
using VB_PROJECTS_NOTES.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05289bc10bfcbface2328696cae52358bd575074", @"/Views/Country/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0935c6e0a3c309dc46ce19568f7f129490c598", @"/Views/_ViewImports.cshtml")]
    public class Views_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<VB_PROJECTS_NOTES.Models.Country>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05289bc10bfcbface2328696cae52358bd5750746784", async() => {
                WriteLiteral(@"
    <div class=""row"">

        <div class=""col-3"">

        </div>
        <div class=""col-5"">
            <input class=""form-control"" name=""SearchString"" type=""text"" placeholder=""Country Name"">

        </div>
        <div class=""col-4"">
            <button type=""submit"" class=""btn btn-light"">Search</button>

        </div>


    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n\r\n\r\n    <div class=\"col-9\">\r\n        <button type=\"button\" class=\"btn btn-secondary btn-sm float-left\"");
            BeginWriteAttribute("onclick", " onclick=\"", 898, "\"", 955, 3);
            WriteAttributeValue("", 908, "location.href=\'", 908, 15, true);
#nullable restore
#line 38 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
WriteAttributeValue("", 923, Url.Action("Index", "Country"), 923, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 954, "\'", 954, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Show All Countries</button>\r\n    </div>\r\n\r\n    <div class=\"col-3\">\r\n        <button type=\"button\" class=\"btn btn-success btn-sm  float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1098, "\"", 1156, 3);
            WriteAttributeValue("", 1108, "location.href=\'", 1108, 15, true);
#nullable restore
#line 42 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
WriteAttributeValue("", 1123, Url.Action("Create", "Country"), 1123, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1155, "\'", 1155, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">New Country</button>
    </div>

</div>


<br />
<br />
<h4>Countries</h4>

<br />

<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Region
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 67 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Region.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05289bc10bfcbface2328696cae52358bd57507411770", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05289bc10bfcbface2328696cae52358bd57507413963", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05289bc10bfcbface2328696cae52358bd57507416162", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05289bc10bfcbface2328696cae52358bd57507418637", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 88 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
           var i = 1; 

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-4\">\r\n\r\n            <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 93 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                 if (Model.PageNumber > 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"page-item\"><button type=\"submit\" name=\"pagina\" value=\"1\" class=\"page-link\" href=\"#\">First</button></li>\r\n");
#nullable restore
#line 96 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                 for (i = 1; i <= Model.PageCount; i++)
                {
                    if (@i == Model.PageNumber)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"page-item\"><button type=\"submit\" name=\"pagina\"");
                BeginWriteAttribute("value", " value=\"", 2749, "\"", 2759, 1);
#nullable restore
#line 102 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
WriteAttributeValue("", 2757, i, 2757, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\" href=\"#\" disabled=\"disabled\" style=\"background: #e8eaec; color: #8b9aa9;\">");
#nullable restore
#line 102 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                                                                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button></li>\r\n");
#nullable restore
#line 103 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                    }

                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"page-item\"><button type=\"submit\" name=\"pagina\"");
                BeginWriteAttribute("value", " value=\"", 3026, "\"", 3036, 1);
#nullable restore
#line 107 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
WriteAttributeValue("", 3034, i, 3034, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\" href=\"#\">");
#nullable restore
#line 107 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button></li>\r\n");
#nullable restore
#line 108 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                 if (Model.PageNumber != (@i - 1))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"page-item\"><button type=\"submit\" name=\"pagina\" value=\"3\" class=\"page-link\" href=\"#\">Last</button></li>\r\n");
#nullable restore
#line 113 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </ul>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\nPage ");
#nullable restore
#line 123 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 123 "C:\Users\marcus.campos\source\repos\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Country\Index.cshtml"
                     Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<VB_PROJECTS_NOTES.Models.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591