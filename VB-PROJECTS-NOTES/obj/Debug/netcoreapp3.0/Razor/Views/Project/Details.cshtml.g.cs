#pragma checksum "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba3470b1fc03bffeafb06f9cc8048a9879bbfc48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Details), @"mvc.1.0.view", @"/Views/Project/Details.cshtml")]
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
#line 1 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\_ViewImports.cshtml"
using VB_PROJECTS_NOTES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\_ViewImports.cshtml"
using VB_PROJECTS_NOTES.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3470b1fc03bffeafb06f9cc8048a9879bbfc48", @"/Views/Project/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0935c6e0a3c309dc46ce19568f7f129490c598", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VB_PROJECTS_NOTES.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Project</h4>\r\n    <hr />\r\n\r\n    <div class=\"my-3 p-3 bg-white rounded shadow-sm\">\r\n        <h4 class=\"border-bottom border-gray pb-2 mb-0\">");
#nullable restore
#line 15 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n        <div class=\"media text-muted pt-3\">\r\n            <p class=\"media-body pb-3 mb-0 lh-125 border-bottom border-gray small-custom\">\r\n                <strong class=\"d-block text-gray-dark\">Country</strong>\r\n                <span>");
#nullable restore
#line 20 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Description</strong>
                <span>");
#nullable restore
#line 27 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Jenkins Address</strong>
                <a");
            BeginWriteAttribute("href", " href=\"", 1238, "\"", 1291, 1);
#nullable restore
#line 34 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
WriteAttributeValue("", 1245, Html.DisplayFor(model => model.JenkisAddress), 1245, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><span>");
#nullable restore
#line 34 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.JenkisAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Backend GitLab Address</strong>
                <a");
            BeginWriteAttribute("href", " href=\"", 1653, "\"", 1703, 1);
#nullable restore
#line 41 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
WriteAttributeValue("", 1660, Html.DisplayFor(model => model.GitAddress), 1660, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><span>");
#nullable restore
#line 41 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.GitAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Provison Git Address (IT OPs)</strong>
                <a");
            BeginWriteAttribute("href", " href=\"", 2069, "\"", 2128, 1);
#nullable restore
#line 48 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
WriteAttributeValue("", 2076, Html.DisplayFor(model => model.ProvisionGitAddress), 2076, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><span>");
#nullable restore
#line 48 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.ProvisionGitAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
            </p>
        </div>


        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Nexus Package Frontend</strong>
                <a");
            BeginWriteAttribute("href", " href=\"", 2498, "\"", 2558, 1);
#nullable restore
#line 56 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
WriteAttributeValue("", 2505, Html.DisplayFor(model => model.NexusFrontEndAddress), 2505, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><span>");
#nullable restore
#line 56 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.NexusFrontEndAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-customlh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Nexus Package NG Product</strong>
                <a");
            BeginWriteAttribute("href", " href=\"", 2928, "\"", 2987, 1);
#nullable restore
#line 63 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
WriteAttributeValue("", 2935, Html.DisplayFor(model => model.NexusProductAddress), 2935, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><span>");
#nullable restore
#line 63 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.NexusProductAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Nexus Package Biometric Product</strong>
                <a");
            BeginWriteAttribute("href", " href=\"", 3364, "\"", 3427, 1);
#nullable restore
#line 70 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
WriteAttributeValue("", 3371, Html.DisplayFor(model => model.BiometricProductAddress), 3371, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><span>");
#nullable restore
#line 70 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                                                                                                    Write(Html.DisplayFor(model => model.BiometricProductAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
            </p>
        </div>

        <div class=""media text-muted pt-3"">
            <p class=""media-body pb-3 mb-0 small-custom lh-125 border-bottom border-gray"">
                <strong class=""d-block text-gray-dark"">Notes</strong>
                <span>");
#nullable restore
#line 77 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n        </div>\r\n\r\n        <small class=\"d-block text-right mt-3\">\r\n            <span style=\"color: #6c757d!important;\">Project Details</span>\r\n        </small>\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba3470b1fc03bffeafb06f9cc8048a9879bbfc4812955", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "Q:\DEVELOPMENT\GIT PROJECTS\VB-PROJECTS-NOTES\VB-PROJECTS-NOTES\Views\Project\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba3470b1fc03bffeafb06f9cc8048a9879bbfc4815111", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VB_PROJECTS_NOTES.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
