#pragma checksum "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9daf3f966ebb0c28e2012ad1d138279ca5425da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Team), @"mvc.1.0.view", @"/Views/Admin/Team.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daf3f966ebb0c28e2012ad1d138279ca5425da8", @"/Views/Admin/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995b751f5351b5d1f4a47ccb87ebdb1031f111f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaxlyAI.Models.ViewModels.AdminTeam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.5em; margin-left: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTeamMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSocialMedia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSMForMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
  
    ViewData["Title"] = "Admin Team";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"display: flex; margin-bottom: 10px;\">\r\n    <h3>Team Members</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9daf3f966ebb0c28e2012ad1d138279ca5425da84775", async() => {
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
            <th scope=""col"">Fullname</th>
            <th scope=""col"">Photo</th>
            <th scope=""col"">Designation</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
         foreach (var member in Model.TeamMembers)
        {
            using (Html.BeginForm("DeleteTeamMember", "Admin", new { id = member.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(member.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(member.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(member.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(member.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(Html.ActionLink("Update", "UpdateTeamMember", "Admin", new { id = member.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\" onclick=\"return confirm(\'Are you sure to delete this information?\')\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"display: flex; margin-bottom: 10px;\">\r\n    <h3>Social Medias</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9daf3f966ebb0c28e2012ad1d138279ca5425da88935", async() => {
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
            <th scope=""col"">Name</th>
            <th scope=""col"">Icon</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 53 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
         foreach (var media in Model.SocialMedias)
        {
            using (Html.BeginForm("DeleteSocialMedia", "Admin", new { id = media.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(media.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(media.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
                   Write(Html.ActionLink("Update", "UpdateSocialMedia", "Admin", new { id = media.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\" onclick=\"return confirm(\'Are you sure to delete this information?\')\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"display: flex; margin-bottom: 10px;\">\r\n    <h3>Social Media Accounts of Members</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9daf3f966ebb0c28e2012ad1d138279ca5425da812496", async() => {
                WriteLiteral("<i class=\"bi bi-plus-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            <th scope=""col"">Member Name</th>
            <th scope=""col"">Social Media</th>
            <th scope=""col"">Url</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 84 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
         foreach (var media in Model.SMsOfMembers)
        {
            using (Html.BeginForm("DeleteSmForMember", "Admin", new { id = media.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 89 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
           Write(media.Member.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 90 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
           Write(media.SocialMedia.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 91 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
           Write(media.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
           Write(Html.ActionLink("Update", "UpdateSmForMember", "Admin", new { id = media.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\" onclick=\"return confirm(\'Are you sure to delete this information?\')\" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 97 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Admin\Team.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaxlyAI.Models.ViewModels.AdminTeam> Html { get; private set; }
    }
}
#pragma warning restore 1591