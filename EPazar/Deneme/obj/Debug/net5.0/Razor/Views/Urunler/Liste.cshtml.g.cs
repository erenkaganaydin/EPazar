#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80468eec71c4bbdb3c76c3f80de0c16fdd2f5b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urunler_Liste), @"mvc.1.0.view", @"/Views/Urunler/Liste.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
using EPazar.Business.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80468eec71c4bbdb3c76c3f80de0c16fdd2f5b2e", @"/Views/Urunler/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Urunler_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UrunlerEntity>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Urunler.css?Id=2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
  
    var UrunListesi = Model.UrunListesi;

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80468eec71c4bbdb3c76c3f80de0c16fdd2f5b2e4692", async() => {
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
       <div class=""urunler-main"">
                <div class=""filtre-div"">
                    <div>
                        <div class=""filter-kategori"">
                            <div class=""filtre-header"">İlgili Kategoriler</div>
                            <div class=""filtre-kategori"">
                                <a href=""#"">Kategori </a>
                                ");
#nullable restore
#line 17 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                           Write(await Component.InvokeAsync("UrunlerKategoriler"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
            WriteLiteral(@"                            <hr class=""filtre-hr"">
                        </div>
                        <div class=""filter-kategori"">
                            <div class=""filtre-header"">Beden</div>
                            <div class=""filtre-kategori"">
                                ");
#nullable restore
#line 25 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                           Write(await Component.InvokeAsync("UrunlerFilter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
            WriteLiteral(@"                            <hr class=""filtre-hr"">
                        </div>
                         <div class=""filter-kategori"">
                            <div class=""filtre-header"">Renk</div>
                            <div class=""filtre-kategori"">
                                ");
#nullable restore
#line 33 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                           Write(await Component.InvokeAsync("UrunlerRenkler"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
            WriteLiteral(@"                            <hr class=""filtre-hr"">
                        </div>
                    </div>
                </div>
                <script>
                     function UruneGit(link) {
                        window.open(
                            '/UrunDetay/' + link,
                            '_blank' // <- This is what makes it open in a new window.
                        );
                };
                </script>
                <div class=""urunler-list"">
                    <div class=""urunler-flex"">
");
#nullable restore
#line 50 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                        foreach (var item in UrunListesi)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"urun-detay\">\r\n                    <div class=\"urun-child\">\r\n                        <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2475, "\"", 2503, 3);
            WriteAttributeValue("", 2485, "UruneGit(", 2485, 9, true);
#nullable restore
#line 54 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
WriteAttributeValue("", 2494, item.Id, 2494, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2502, ")", 2502, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"  >
                            <div class=""urun-detay-img"">
                                <div class=""image-overlay"">
                                    <div class=""image-overlay-header"">
                                        <div class=""overlay-kargo-durum"">
                                            <div class=""kargo-durum-metin"">KARGO BEDAVA</div>
                                        </div>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2960, "\"", 3007, 2);
            WriteAttributeValue("", 2967, "/Hesabim/Favorilerim/FavoriEkle/", 2967, 32, true);
#nullable restore
#line 61 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
WriteAttributeValue("", 2999, item.Id, 2999, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  style=""z-index:99"" class=""overlay-favori-ekle"">
                                            <i class=""far fa-heart overlay-favori-ekle-metin""></i>
                                        </a>
                                    </div>
                                    <div class=""image-overlay-body""></div>
                                    <div class=""image-overlay-footer""></div>
                                </div>

");
#nullable restore
#line 69 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                                  
                                    var UrunResimi = item.UrunResimleri.FirstOrDefault();
                                    if (UrunResimi == null)
                                        UrunResimi.ResimLink = "https://UrunResmiYok.com";
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div>\r\n                                            <img class=\"urun-detay-resim\"");
            BeginWriteAttribute("src", " src=\"", 3880, "\"", 3907, 1);
#nullable restore
#line 75 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
WriteAttributeValue("", 3886, UrunResimi.ResimLink, 3886, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3908, "\"", 3914, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>

                                    </div>
                                    <div class=""urun-detay-aciklama"">
                                        <div class=""urun-detay-aciklama-baslik"">
                                            <span class=""urun-detay-aciklama-baslik-span"">Marka</span>
                                            <span class=""urun-detay-aciklama-baslik-span-acikalama"">
                                                ");
#nullable restore
#line 83 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                                           Write(item.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>
                                        </div>
                                        <div class=""urun-detay-fiyat"">
                                            <div class=""fiyat-wrap"">
                                                <div class=""fiyat-old"">");
#nullable restore
#line 88 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                                                                  Write(item.EskiFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</div>\r\n                                                <div class=\"fiyat-gecerli\">");
#nullable restore
#line 89 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                                                                      Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₺</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 96 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Urunler\Liste.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UrunlerEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
