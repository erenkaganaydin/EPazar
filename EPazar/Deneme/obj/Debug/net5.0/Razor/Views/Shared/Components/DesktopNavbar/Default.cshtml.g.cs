#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a096ef64e719fabe6a86deeab834682a6320a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DesktopNavbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DesktopNavbar/Default.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\_ViewImports.cshtml"
using EPazar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\_ViewImports.cshtml"
using EPazar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a096ef64e719fabe6a86deeab834682a6320a7a", @"/Views/Shared/Components/DesktopNavbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_DesktopNavbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NavbarEntityleri>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sub-category-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sub-item-li"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
  
    var AnaKategorilerList = Model.AnaKategorilerList;
    var KategorilerList = Model.KategorilerList;
    var AltKategorilerList = Model.AltKategorilerList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"category-navigator\">\r\n        <div class=\"category-navigator-wrap\">\r\n            <nav>\r\n                <ul class=\"main-nav\">\r\n");
#nullable restore
#line 17 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                     foreach (var AnaKategoriItem in AnaKategorilerList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"tab-link\">\r\n");
#nullable restore
#line 20 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                             if(AnaKategoriItem.Id == 1 || AnaKategoriItem.Id == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a096ef64e719fabe6a86deeab834682a6320a7a6282", async() => {
#nullable restore
#line 22 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                                                                                                                Write(AnaKategoriItem.Ad);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 738, "~/KategoriListesi/Listele/", 738, 26, true);
#nullable restore
#line 22 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 764, AnaKategoriItem.Id, 764, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 783, "/", 783, 1, true);
#nullable restore
#line 22 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 784, Html.Raw(AnaKategoriItem.Ad), 784, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 813, "?Tumu=1", 813, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a096ef64e719fabe6a86deeab834682a6320a7a8976", async() => {
#nullable restore
#line 25 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                                                                                                      Write(AnaKategoriItem.Ad);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 978, "~/Urunler/Liste/", 978, 16, true);
#nullable restore
#line 25 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 994, AnaKategoriItem.Id, 994, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1013, "/", 1013, 1, true);
#nullable restore
#line 25 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 1014, Html.Raw(AnaKategoriItem.Ad), 1014, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1043, "?Tumu=1", 1043, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                              var Kategorileri = KategorilerList.Where(x=>x.AnaKategoriId == AnaKategoriItem.Id).ToList().Take(6); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"sub-nav\">\r\n                                <div class=\"sub-nav-center\">\r\n                                    <div class=\"sub-nav-outer\">\r\n");
#nullable restore
#line 31 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                         foreach(var KategoriItem in Kategorileri)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"normal-column\">\r\n                                                <div class=\"category-box\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a096ef64e719fabe6a86deeab834682a6320a7a12655", async() => {
                WriteLiteral("\r\n                                                        ");
#nullable restore
#line 36 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                   Write(KategoriItem.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 9, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1781, "~/Urunler/Liste/", 1781, 16, true);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 1797, KategoriItem.AnaKategoriId, 1797, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1824, "/", 1824, 1, true);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 1825, Html.Raw(AnaKategoriItem.Ad), 1825, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1854, "/", 1854, 1, true);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 1855, KategoriItem.Id, 1855, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1871, "/", 1871, 1, true);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 1872, Html.Raw(KategoriItem.Ad), 1872, 26, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1898, "/?Tumu=1", 1898, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                      var AltKategorileri = AltKategorilerList.Where(x=>x.KategoriId == KategoriItem.Id).ToList(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <ul class=\"sub-item-list\">\r\n");
#nullable restore
#line 40 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                         foreach(var AltKategoriItem in AltKategorileri)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a096ef64e719fabe6a86deeab834682a6320a7a16686", async() => {
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                                                                                                                                                                                                                                        Write(AltKategoriItem.Ad);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 13, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2538, "~/Urunler/Liste/", 2538, 16, true);
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 2554, KategoriItem.AnaKategoriId, 2554, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2581, "/", 2581, 1, true);
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 2582, Html.Raw(AnaKategoriItem.Ad), 2582, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2611, "/", 2611, 1, true);
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 2612, KategoriItem.Id, 2612, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2628, "/", 2628, 1, true);
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 2629, Html.Raw(KategoriItem.Ad), 2629, 26, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2655, "/", 2655, 1, true);
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 2656, AltKategoriItem.Id, 2656, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2675, "/", 2675, 1, true);
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
AddHtmlAttributeValue("", 2676, Html.Raw(AltKategoriItem.Ad), 2676, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2705, "?Tumu=1", 2705, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 47 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"


                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       \r\n                                </div>\r\n                                </div>\r\n                            </div>\r\n                    </li>\r\n");
#nullable restore
#line 55 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\DesktopNavbar\Default.cshtml"
                    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n            </nav>\r\n        </div>\r\n        <div class=\"container-black\">\r\n          \r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NavbarEntityleri> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
