#pragma checksum "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c89de5a91c399d52069b9998c8000a6cb93e906"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Projects), @"mvc.1.0.view", @"/Views/Admin/Projects.cshtml")]
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
#line 1 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\_ViewImports.cshtml"
using NaxlyAI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c89de5a91c399d52069b9998c8000a6cb93e906", @"/Views/Admin/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995b751f5351b5d1f4a47ccb87ebdb1031f111f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaxlyAI.Models.ViewModels.AdminProjects>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.5em; margin-left: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProjectStep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
  
    ViewData["Title"] = "Projects";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"display: flex; margin-bottom: 10px;\">\r\n    <h3>Projects</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c89de5a91c399d52069b9998c8000a6cb93e9064485", async() => {
                WriteLiteral("<i class=\"bi bi-plus-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<table style=""margin-bottom: 5%;"" class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Page Header</th>
            <th scope=""col"">Time Period</th>
            <th scope=""col"">Website</th>
            <th scope=""col"">Cover Picture</th>
            <th scope=""col"">Process Description</th>
            <th scope=""col"">Result Description</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
         foreach (var project in Model.Projects)
        {
            using (Html.BeginForm("DeleteProject", "Admin", new { id = project.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.PageHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.TimePeriod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.CoverPicture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.ProcessDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(project.ResultDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(Html.ActionLink("Update", "UpdateProject", "Admin", new { id = project.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(Html.ActionLink("Details", "ProjectDetails", "Admin", new { id = project.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\" onclick=\"return confirm(\'Are you sure to delete this information?\')\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"display: flex; margin-bottom: 10px;\">\r\n<h3>Steps of Projects</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c89de5a91c399d52069b9998c8000a6cb93e9069972", async() => {
                WriteLiteral("<i class=\"bi bi-plus-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<table style=""margin-bottom: 5%;"" class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Parent Project</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Picture</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 62 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
         foreach (var step in Model.StepsOfProjects)
        {
            using (Html.BeginForm("DeleteProjectStep", "Admin", new { id = step.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(step.Project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(step.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(step.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(step.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
                   Write(Html.ActionLink("Update", "UpdateProjectStep", "Admin", new { id = step.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\" onclick=\"return confirm(\'Are you sure to delete this information?\')\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Projects.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaxlyAI.Models.ViewModels.AdminProjects> Html { get; private set; }
    }
}
#pragma warning restore 1591
