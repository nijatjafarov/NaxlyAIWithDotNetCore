#pragma checksum "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28e08e94b774a08555e1627f2fcde5df052faece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e08e94b774a08555e1627f2fcde5df052faece", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995b751f5351b5d1f4a47ccb87ebdb1031f111f1", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaxlyAI.Models.ViewModels.AppAbout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-style-four"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
  
    ViewData["Title"] = "About Company";
    ViewData["PageName"] = "About";
    ViewData["PageHeader"] = Model.AboutPage.PageHeader;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
Write(Html.Partial("PageTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- about-style-six -->
<section class=""about-style-six"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <div class=""col-lg-6 col-md-12 col-sm-12 image-column"">
                <div id=""image_block_05"">
                    <div class=""image-box"">
                        <figure class=""image image-1""><img");
            BeginWriteAttribute("src", " src=\"", 565, "\"", 603, 2);
            WriteAttributeValue("", 571, "images/", 571, 7, true);
#nullable restore
#line 17 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 578, Model.AboutPage.Picture1, 578, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 604, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                        <figure class=\"image image-2\"><img");
            BeginWriteAttribute("src", " src=\"", 681, "\"", 719, 2);
            WriteAttributeValue("", 687, "images/", 687, 7, true);
#nullable restore
#line 18 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 694, Model.AboutPage.Picture2, 694, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 720, "\"", 726, 0);
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                        <figure class=\"image image-3\"><img");
            BeginWriteAttribute("src", " src=\"", 797, "\"", 835, 2);
            WriteAttributeValue("", 803, "images/", 803, 7, true);
#nullable restore
#line 19 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 810, Model.AboutPage.Picture3, 810, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 836, "\"", 842, 0);
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                        <div class=""elipse""></div>
                        <div class=""pattern-layer"" style=""background-image: url(images/shape/shape-46.png);""></div>
                        <div class=""text"">
                            <span>");
#nullable restore
#line 23 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                              Write(DateTime.Now.Year - Model.AboutPage.FoundationYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            <h5>Years<br />of Experience</h5>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12 col-sm-12 content-column"">
                <div id=""content_block_11"">
                    <div class=""content-box"">
                        <div class=""sec-title text-left"">
                            <p>About Company</p>
                            <h2>");
#nullable restore
#line 34 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                           Write(Model.AboutPage.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <div class=\"decor\" style=\"background-image: url(images/icons/decor-1.png);\"></div>\r\n                        </div>\r\n                        <div class=\"text\">\r\n                            <p>");
#nullable restore
#line 38 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                          Write(Model.AboutPage.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                         if (Model.AboutPage.VideoUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"video-btn\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2128, "\"", 2160, 1);
#nullable restore
#line 43 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 2135, Model.AboutPage.VideoUrl, 2135, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"lightbox-image\" data-caption=\"\"><i class=\"flaticon-play-button\"></i></a>\r\n                                <h5>");
#nullable restore
#line 44 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                               Write(Model.AboutPage.VideoTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n");
#nullable restore
#line 46 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- about-style-six end -->
<!-- history-section -->
<section class=""history-section"">
    <div class=""pattern-layer"" style=""background-image: url(images/shape/shape-47.png);""></div>
    <div class=""arrow-box"" style=""background-image: url(images/icons/arrow-3.png);""></div>
    <figure class=""image-layer js-tilt""><img src=""images/resource/illastration-8.png""");
            BeginWriteAttribute("alt", " alt=\"", 2853, "\"", 2859, 0);
            EndWriteAttribute();
            WriteLiteral(@"></figure>
    <div class=""auto-container"">
        <div class=""sec-title text-left"">
            <p>Our History</p>
            <h2>History begins in 2010 with the foundation</h2>
            <div class=""decor"" style=""background-image: url(images/icons/decor-1.png);""></div>
        </div>
        <div class=""inner-box clearfix"">
");
#nullable restore
#line 66 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
               int index = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
             foreach (StepOfHistory step in Model.StepsOfHistory)
            {
                bool up = index % 2 == 0;
                string divClass = up ? "slideInUp" : "slideInDown";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"single-item\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 3495, "\"", 3522, 3);
            WriteAttributeValue("", 3503, "inner", 3503, 5, true);
            WriteAttributeValue(" ", 3508, "wow", 3509, 4, true);
#nullable restore
#line 73 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue(" ", 3512, divClass, 3513, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-wow-delay=\"00ms\" data-wow-duration=\"1500ms\">\r\n");
#nullable restore
#line 74 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                         if (up)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-box\">\r\n                                <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e08e94b774a08555e1627f2fcde5df052faece12426", async() => {
#nullable restore
#line 77 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                                                            Write(step.Header);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 78 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                              Write(step.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"year\"><span>");
#nullable restore
#line 80 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                               Write(step.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 81 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"year\"><span>");
#nullable restore
#line 84 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                               Write(step.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                            <div class=\"content-box\">\r\n                                <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e08e94b774a08555e1627f2fcde5df052faece15318", async() => {
#nullable restore
#line 86 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                                                            Write(step.Header);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 87 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                              Write(step.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 89 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 92 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"

                index++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- history-section end -->
<!-- chooseus-style-four -->
<section class=""chooseus-style-four"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <div class=""col-lg-6 col-md-12 col-sm-12 image-column"">
                <div class=""image-box"">
                    <figure class=""image image-1 wow slideInLeft"" data-wow-delay=""00ms"" data-wow-duration=""1500ms"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 4962, "\"", 5011, 2);
            WriteAttributeValue("", 4968, "images/", 4968, 7, true);
#nullable restore
#line 106 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 4975, Model.AboutPage.WhyChooseUsPicture1, 4975, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5012, "\"", 5018, 0);
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                    <figure class=\"image image-2  wow slideInLeft\" data-wow-delay=\"300ms\" data-wow-duration=\"1500ms\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5172, "\"", 5222, 2);
            WriteAttributeValue("", 5179, "images/", 5179, 7, true);
#nullable restore
#line 108 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 5186, Model.AboutPage.WhyChooseUsPicture2, 5186, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"lightbox-image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 5277, "\"", 5326, 2);
            WriteAttributeValue("", 5283, "images/", 5283, 7, true);
#nullable restore
#line 109 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 5290, Model.AboutPage.WhyChooseUsPicture2, 5290, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5327, "\"", 5333, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></figure>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12 col-sm-12 content-column"">
                <div id=""content_block_12"">
                    <div class=""content-box"">
                        <div class=""sec-title text-left"">
                            <p>Why Choose Us</p>
                            <h2>");
#nullable restore
#line 117 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                           Write(Model.AboutPage.WhyChooseUs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <div class=\"decor\" style=\"background-image: url(images/icons/decor-1.png);\"></div>\r\n                        </div>\r\n                        <div class=\"inner-box\">\r\n");
#nullable restore
#line 121 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                             foreach (ReasonForChoosingU reason in Model.reasonsForChoosingUs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-item\">\r\n                                    <h4>");
#nullable restore
#line 124 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                   Write(reason.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <div class=\"box\">\r\n                                        <div class=\"icon-box\"><i");
            BeginWriteAttribute("class", " class=\"", 6292, "\"", 6312, 1);
#nullable restore
#line 126 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 6300, reason.Icon, 6300, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                                        <p>");
#nullable restore
#line 127 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                      Write(reason.Descrioption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 130 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- chooseus-style-four end -->
<!-- testimonial-style-two -->
<section class=""testimonial-style-two alternate-2"">
    <div class=""lower-content"">
        <div class=""auto-container"">
            <div class=""testimonial-carousel-2 owl-carousel owl-theme owl-dots-none owl-nav-none"">
");
#nullable restore
#line 144 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                 foreach (Testimonial testimonial in Model.Testimonials)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"testimonial-content\">\r\n                        <div class=\"inner-box\">\r\n                            <figure class=\"image-box\"><img");
            BeginWriteAttribute("src", " src=\"", 7199, "\"", 7230, 2);
            WriteAttributeValue("", 7205, "images/", 7205, 7, true);
#nullable restore
#line 148 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 7212, testimonial.Photo, 7212, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7231, "\"", 7237, 0);
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                            <div class=""content-box"">
                                <div class=""icon-box"" style=""background-image: url(images/icons/icon-5.png);""></div>
                                <div class=""text"">
                                    <p>");
#nullable restore
#line 152 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                  Write(testimonial.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"author-info\">\r\n                                    <h4>");
#nullable restore
#line 155 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                   Write(testimonial.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <span class=\"designation\">");
#nullable restore
#line 156 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                                         Write(testimonial.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 161 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<!-- testimonial-style-two end -->
<!-- team-section -->
<section class=""team-section alternate-2"">
    <div class=""auto-container"">
        <div class=""sec-title text-center mb-60"">
            <p>team MEmbers</p>
            <h2>");
#nullable restore
#line 172 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
           Write(Model.AboutPage.TeamMemberDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <div class=\"decor\" style=\"background-image: url(images/icons/decor-1.png);\"></div>\r\n        </div>\r\n        <div class=\"row clearfix\">\r\n");
#nullable restore
#line 176 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
             foreach (TeamMember member in Model.TeamMembers)
            {
                IEnumerable<SocialMediaAccountOfMember> socialMedias = new NaxlyAIContext().SocialMediaAccountOfMembers.
                    Where(s => s.MemberId == member.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 col-sm-12 team-block"">
                    <div class=""team-block-one wow fadeInUp"" data-wow-delay=""00ms"" data-wow-duration=""1500ms"">
                        <div class=""inner-box"">
                            <div class=""image-box"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 9017, "\"", 9043, 2);
            WriteAttributeValue("", 9023, "images/", 9023, 7, true);
#nullable restore
#line 184 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 9030, member.Photo, 9030, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9044, "\"", 9050, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <ul class=\"contact-box clearfix\">\r\n                                    <li class=\"email\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 9219, "\"", 9246, 2);
            WriteAttributeValue("", 9226, "mailto:", 9226, 7, true);
#nullable restore
#line 187 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 9233, member.Email, 9233, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"flaticon-gmail\"></i>\r\n                                            <span>");
#nullable restore
#line 189 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
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
#line 195 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                             foreach (SocialMediaAccountOfMember sm in socialMedias)
                                            {
                                                string icon = new NaxlyAIContext().SocialMedia.
                                                                Where(s => s.Id == sm.SocialMediaId).
                                                                FirstOrDefault().Icon;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 10213, "\"", 10227, 1);
#nullable restore
#line 200 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 10220, sm.Url, 10220, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 10231, "\"", 10244, 1);
#nullable restore
#line 200 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
WriteAttributeValue("", 10239, icon, 10239, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                     </i></a></li>\r\n");
#nullable restore
#line 202 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
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
#line 208 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                           Write(member.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <span class=\"designation\">");
#nullable restore
#line 209 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
                                                     Write(member.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 214 "C:\Users\Nijat\Desktop\Naxly\NaxlyAI\NaxlyAI\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"more-btn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e08e94b774a08555e1627f2fcde5df052faece31888", async() => {
                WriteLiteral("\r\n            Meet All Members<span>+</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n    </div>\r\n</section>\r\n<!-- team-section end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaxlyAI.Models.ViewModels.AppAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591
