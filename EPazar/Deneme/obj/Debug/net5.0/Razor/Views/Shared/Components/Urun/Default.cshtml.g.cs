#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5d7d23ee91e0c3979fbed4e9729c30b0fe04a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Urun_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Urun/Default.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d7d23ee91e0c3979fbed4e9729c30b0fe04a76", @"/Views/Shared/Components/Urun/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Urun_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UrunComponent>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
  
    var Urun = Model.Urun;
    var UrunResimleri = Model.UrunResimleri;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""urun-detay"">
                            <div class=""urun-child"">
                                <a href=""#"">
                            <div class=""urun-detay-img"">
                                <div class=""image-overlay"">
                                    <div class=""image-overlay-header"">
                                        <div class=""overlay-kargo-durum"">
                                            <div class=""kargo-durum-metin"">KARGO BEDAVA</div>
                                        </div>
                                        <div class=""overlay-favori-ekle"">
                                            <i class=""far fa-heart overlay-favori-ekle-metin""></i>
                                        </div>
                                    </div>
                                    <div class=""image-overlay-body""></div>
                                    <div class=""image-overlay-footer""></div>
                                </div>
    ");
            WriteLiteral("                          \r\n                                        <div>\r\n                                            <img class=\"urun-detay-resim\"");
            BeginWriteAttribute("src", " src=\"", 1311, "\"", 1341, 1);
#nullable restore
#line 26 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
WriteAttributeValue("", 1317, UrunResimleri.ResimLink, 1317, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1342, "\"", 1357, 1);
#nullable restore
#line 26 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
WriteAttributeValue("", 1348, Urun.Adi, 1348, 9, false);

#line default
#line hidden
#nullable disable
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
#line 34 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
                                           Write(Urun.Adi);

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
#line 39 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
                                                                  Write(Urun.EskiFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <div class=\"fiyat-gecerli\">");
#nullable restore
#line 40 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\Urun\Default.cshtml"
                                                                      Write(Urun.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UrunComponent> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
