#pragma checksum "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbfcb1fe2bc23e3ab54b4c5fbe253be4abee802e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbfcb1fe2bc23e3ab54b4c5fbe253be4abee802e", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995b751f5351b5d1f4a47ccb87ebdb1031f111f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaxlyAI.Models.ViewModels.AppTeam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["PageHeader"] = "Meet Our Team";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
Write(Html.Partial("PageTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- team-section -->\r\n<section class=\"team-page-section\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"sec-title text-center mb-60\">\r\n            <p>team MEmbers</p>\r\n            <h2>");
#nullable restore
#line 14 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
           Write(Model.About.TeamMemberDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <div class=\"decor\" style=\"background-image: url(images/icons/decor-1.png);\"></div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
             foreach (TeamMember member in Model.Members)
            {
                var socialMedias = new NaxlyAIContext().SocialMediaAccountOfMembers.
                                                    Where(s => s.MemberId == member.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 col-sm-12 team-block"">
                    <div class=""team-block-one wow fadeInUp"" data-wow-delay=""00ms"" data-wow-duration=""1500ms"">
                        <div class=""inner-box"">
                            <div class=""image-box"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 1099, "\"", 1125, 2);
            WriteAttributeValue("", 1105, "images/", 1105, 7, true);
#nullable restore
#line 26 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
WriteAttributeValue("", 1112, member.Photo, 1112, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1126, "\"", 1132, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <ul class=\"contact-box clearfix\">\r\n                                    <li class=\"email\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1301, "\"", 1328, 2);
            WriteAttributeValue("", 1308, "mailto:", 1308, 7, true);
#nullable restore
#line 29 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
WriteAttributeValue("", 1315, member.Email, 1315, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"flaticon-gmail\"></i>\r\n                                            <span>");
#nullable restore
#line 31 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
                                             Write(member.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </a>
                                    </li>
                                    <li class=""social-links"">
                                        <a href=""#"" class=""share""><i class=""flaticon-share-1""></i></a>
                                        <ul class=""list clearfix"">
");
#nullable restore
#line 37 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
                                             foreach (SocialMediaAccountOfMember sm in socialMedias)
                                            {
                                                var socialMedia = new NaxlyAIContext().SocialMedia.
                                                    Find(sm.SocialMediaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2185, "\"", 2199, 1);
#nullable restore
#line 41 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
WriteAttributeValue("", 2192, sm.Url, 2192, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2203, "\"", 2228, 1);
#nullable restore
#line 41 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
WriteAttributeValue("", 2211, socialMedia.Icon, 2211, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 42 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </ul>
                                    </li>
                                </ul>
                            </div>
                            <div class=""lower-content"">
                                <h4><a href=""#"">");
#nullable restore
#line 48 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
                                           Write(member.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <span class=\"designation\">");
#nullable restore
#line 49 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
                                                     Write(member.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\Team\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!-- team-section end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaxlyAI.Models.ViewModels.AppTeam> Html { get; private set; }
    }
}
#pragma warning restore 1591
