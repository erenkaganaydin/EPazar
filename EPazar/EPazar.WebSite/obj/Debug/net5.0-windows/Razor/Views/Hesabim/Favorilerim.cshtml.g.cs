#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e9c8cd24ef700e54eb58bfc5cd2dbcf0da4f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hesabim_Favorilerim), @"mvc.1.0.view", @"/Views/Hesabim/Favorilerim.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\_ViewImports.cshtml"
using EPazar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\_ViewImports.cshtml"
using EPazar.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e9c8cd24ef700e54eb58bfc5cd2dbcf0da4f2a", @"/Views/Hesabim/Favorilerim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c449f062d2bc7dfc52d3cce572b68bf290fe40c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hesabim_Favorilerim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Favoriler>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Favoriler.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("onerilen-urun-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "51e9c8cd24ef700e54eb58bfc5cd2dbcf0da4f2a4517", async() => {
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
            WriteLiteral(@"
    
    <div class=""alc-hesap-container"">
                <div class=""l-sol-hesabim-nav"">
                    <div class=""block"">
                        <div class=""alc-hesap-yerlesim-container block"">
                            <div class=""lw-yerlesim-wrap"">

                                <h2>Hesab??m</h2>
                                <a class=""text-decore-x yerlesim-item "" href=""/Hesabim/Siparislerim"">
                                    <i class=""fa fa-box item-i""></i>
                                    <span>Sipari??lerim</span>
                                </a>
                                <a class=""text-decore-x yerlesim-item "" href=""/Hesabim/HesapBilgileri"">
                                    <i class=""fa fa-user item-i""></i>
                                    <span>Hesap Bilgileri</span>
                                </a>

                                <a class=""text-decore-x yerlesim-item yerlesim-aktif"" href=""/Hesabim/Favorilerim"">
                             ");
            WriteLiteral(@"       <i class=""fa fa-heart item-i""></i>
                                    <span>Favorilerim</span>
                                </a>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""r-sag-div"">

                    <div class=""block"">

                        <div class=""oc-block"">

                            <div class=""hb-header"">
                                <h1> <i class=""fa fa-heart item-i""></i> Favoriler</h1>
                            </div>

                            <div class=""block"" style=""width: 100%;"">

                                <div class=""favori-block-wrap"">
");
#nullable restore
#line 45 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
                                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <div class=\"onerilen-urun-kart-wrap\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51e9c8cd24ef700e54eb58bfc5cd2dbcf0da4f2a7843", async() => {
                WriteLiteral("\r\n                                            <div class=\"img-wrap\">\r\n                                                <img class=\"o-item-img\"");
                BeginWriteAttribute("src", " src=\"", 2241, "\"", 2262, 1);
#nullable restore
#line 49 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
WriteAttributeValue("", 2247, item.ResimLink, 2247, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2263, "\"", 2286, 1);
#nullable restore
#line 49 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
WriteAttributeValue("", 2269, item.Urunler.Adi, 2269, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                            <div>
                                                <div class=""o-shipp-wrap"">
                                                    <div class=""o-kargo-bedava"">KARGO BEDAVA</div>
                                                </div>
                                            </div>
                                            <div class=""o-urun-desc-center-wrap"">
                                                <div class=""o-urun-desc-center"">
                                                    <div class=""o-urun-desc-title"">
                                                        <span class=""o-urun-desc-marka""></span>
                                                        <span class=""o-urun-desc-aciklama""> ");
#nullable restore
#line 60 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
                                                                                       Write(item.Urunler.Adi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                    </div>
                                                </div>
                                                <div class=""o-urun-fiyat"">
                                                    <div class=""prd-bx"">
                                                        <div class=""prd-bx-na"">
                                                            <div class=""urun-box-eski"">");
#nullable restore
#line 66 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
                                                                                  Write(item.Urunler.EskiFiyat);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ??? </div>\r\n                                                            <div class=\"urun-box-yeni-f\">");
#nullable restore
#line 67 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
                                                                                    Write(item.Urunler.Fiyat);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ???</div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2047, "~/UrunDetay/", 2047, 12, true);
#nullable restore
#line 47 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
AddHtmlAttributeValue("", 2059, item.UrunId, 2059, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 74 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\Favorilerim.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Favoriler>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
