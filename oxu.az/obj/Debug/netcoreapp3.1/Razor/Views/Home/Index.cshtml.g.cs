#pragma checksum "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c1a2fbfef0e8a232f28c954366aa8d202748a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(oxuAz.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace oxuAz.Pages.Home
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
#line 1 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\_ViewImports.cshtml"
using oxuAz;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c1a2fbfef0e8a232f28c954366aa8d202748a7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc9b5c9a42cb5eede34f9f88d45907f79308cf4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<oxuAz.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/news.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carusel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("StyleCSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1c1a2fbfef0e8a232f28c954366aa8d202748a74279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""featured-container"">


    <div class=""featured"">
        <div class=""featured-switch  featured-switch_prev s-left"">
            <i class=""fas fa-chevron-left featured-left-arrow s-left""></i>
        </div>
        <div class=""featured-switch featured-switch_next s-next"">
            <i class=""fas fa-chevron-right featured-right-arrow ""></i>
        </div>
        <div class=""featured-content"">
");
#nullable restore
#line 20 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"featured-i\"");
            BeginWriteAttribute("href", " href=\"", 694, "\"", 723, 2);
            WriteAttributeValue("", 701, "/home/details/", 701, 14, true);
#nullable restore
#line 22 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
WriteAttributeValue("", 715, item.Id, 715, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 751, "\"", 757, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"featured-i-img\"");
            BeginWriteAttribute("src", " src=\'", 781, "\'", 833, 1);
#nullable restore
#line 23 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
WriteAttributeValue("", 787, Url.Content($"~/NewsAsserts/{item.FileName}"), 787, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"featured-i-content\">\r\n                        <div class=\"featured-i-meta-container\">\r\n                            <div class=\"featured-i-meta\">\r\n                                <span class=\"featured-i-date\"> ");
#nullable restore
#line 27 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                                          Write(item.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                                                         Write(item.Date.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"featured-i-time\">");
#nullable restore
#line 28 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                                         Write(item.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"featured-i-views\">");
#nullable restore
#line 29 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                                          Write(item.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"featured-i-text\">\r\n                            <div class=\"featured-i-title\">\r\n                                ");
#nullable restore
#line 34 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"featured-i-description\"></div>\r\n                        </div>\r\n                    </div>\r\n                </a>");
#nullable restore
#line 39 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<section class=\"news-list\">\r\n");
#nullable restore
#line 44 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
     foreach (var news in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"news-i\">\r\n            <a class=\"news-i-inner\"");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1931, 2);
            WriteAttributeValue("", 1909, "/home/details/", 1909, 14, true);
#nullable restore
#line 47 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
WriteAttributeValue("", 1923, news.Id, 1923, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"news-i-img-container\">\r\n                    <div class=\"news-i-img\"");
            BeginWriteAttribute("style", " style=\"", 2030, "\"", 2104, 4);
            WriteAttributeValue("", 2038, "background:", 2038, 11, true);
            WriteAttributeValue(" ", 2049, "url(\'", 2050, 6, true);
#nullable restore
#line 49 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
WriteAttributeValue("", 2055, Url.Content($"~/NewsAsserts/{news.FileName}"), 2055, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2101, "\');", 2101, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"news-i-content\">\r\n                    <div class=\"when\">\r\n                        <div class=\"when-date\">\r\n                            <div class=\"date-day\">");
#nullable restore
#line 54 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                             Write(news.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n                            <div class=\"date-month\">");
#nullable restore
#line 55 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                               Write(news.Date.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"date-year\">");
#nullable restore
#line 56 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                              Write(news.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"when-time\">");
#nullable restore
#line 58 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                          Write(news.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                   Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"description\"></div>\r\n                </div>\r\n            </a>\r\n            <div class=\"stats\" data-id=\"");
#nullable restore
#line 66 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                                   Write(news.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <div class=\"stats-i-container stats-like-active stats_likes\">\r\n                    <span class=\"stats-i up\">\r\n                        <i class=\"fas fa-thumbs-up\"></i>\r\n                        <span>");
#nullable restore
#line 70 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                         Write(news.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </span>
                </div>
                <div class=""stats-i-container stats-like-active stats_dislikes"">
                    <span class=""stats-i down"">
                        <i class=""fas fa-thumbs-down""></i>
                        <span>");
#nullable restore
#line 76 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                         Write(news.Dislikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </span>\r\n                </div>\r\n                <div class=\"stats-i-container stats_views\">\r\n                    <span class=\"stats-i\">\r\n                        <i class=\"fas fa-eye\"></i>\r\n                        ");
#nullable restore
#line 82 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
                   Write(news.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>");
#nullable restore
#line 86 "C:\Users\MrUnknown\source\repos\oxu.az\oxu.az\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1c1a2fbfef0e8a232f28c954366aa8d202748a715202", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<oxuAz.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
