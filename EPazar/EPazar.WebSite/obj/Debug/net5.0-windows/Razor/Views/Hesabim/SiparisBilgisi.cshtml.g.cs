#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0782fd3dd18055e137353bae34db24af25c5a3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hesabim_SiparisBilgisi), @"mvc.1.0.view", @"/Views/Hesabim/SiparisBilgisi.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0782fd3dd18055e137353bae34db24af25c5a3bd", @"/Views/Hesabim/SiparisBilgisi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c449f062d2bc7dfc52d3cce572b68bf290fe40c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hesabim_SiparisBilgisi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiparisBilgisiEntityleri>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/SiparisDetay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
  
    var Siparisler = Model.Siparis;
    var SiparisDetaylari = Model.ViewSiparisDetay;
    var SiparisKargoBilgisi = Model.SiparisKargoBilgisi;

    var ToplamTutar = Math.Round(SiparisDetaylari.Sum(x => x.Toplam), 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0782fd3dd18055e137353bae34db24af25c5a3bd4810", async() => {
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

                                <h2>Hesabım</h2>
                                <a class=""text-decore-x yerlesim-item yerlesim-aktif"" href=""/Hesabim/Siparislerim"">
                                    <i class=""fa fa-box item-i""></i>
                                    <span>Siparişlerim</span>
                                </a>
                                <a class=""text-decore-x yerlesim-item"" href=""/Hesabim/HesapBilgileri"">
                                    <i class=""fa fa-user item-i""></i>
                                    <span>Hesap Bilgileri</span>
                                </a>
                                 <a class=""text-decore-x yerlesim-item "" href=""/Hesabim/Favorilerim"">
                                   ");
            WriteLiteral(@" <i class=""fa fa-heart item-i""></i>
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
                                <h1>Sipariş Detay</h1>
                            </div>

                            <div class=""block"">
                                <div class=""odc-siparis-detay-icerigi"">
");
#nullable restore
#line 51 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                      
                                        var Tedarikciler = SiparisDetaylari.GroupBy(x=> x.TedarikciAdi).Select(x=> x.Key).ToList();
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                     foreach(var tedarikci in Tedarikciler){
                                        var TedarikciUrunleri = SiparisDetaylari.Where(x=> x.TedarikciAdi == tedarikci).ToList(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"ods-siparis-detay-urunler\">\r\n                                            <div class=\"h-siparis-detay-header\">\r\n");
#nullable restore
#line 58 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                 foreach(var item in SiparisKargoBilgisi){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""si-kargo-bilgi"">
                                                    <div class=""ss-siparis-numarasi"">
                                                        <div class=""siw-icon-wrap""><i class=""fa fa-box""></i></div>
                                                        <div class=""si-kargo-bilgi-text"">
                                                            <span><b>Kargo No</b></span>
                                                            <span>");
#nullable restore
#line 64 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                             Write(item.KargoTakipKodu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                        </div>

                                                    </div>
                                                    <div class=""sc-kargo-bilgisi"">
                                                        <span>Kargo Firması</span>
                                                        <span>");
#nullable restore
#line 70 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                         Write(item.KargoFirmalari.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 73 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        

                                            </div>

                                            <div class=""scs-urun-detay-satici"">
                                                <div class="" scs-urun-detay-satici-header"">
                                                    <span class=""ssst-gonderen"">Gönderen :</span>
                                                    <div class=""tih-satici-adi"">
                                                        <a style=""color: #4d84e2"" class=""text-decore-x"" href=""#"">");
#nullable restore
#line 82 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                                                            Write(tedarikci);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""ss-cont"">
                                                <div class=""scsw-kargo-durum-wrap"">
                                                    <div class=""scs-kargo-durumu"">
                                                        <div class=""scsd-durum-detay"">
                                                            <i class=""fa fa-check i-right""></i>
                                                            <span>");
#nullable restore
#line 91 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                             Write(Siparisler.SiparisDurum.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </div>\r\n                                                        <div class=\"scsi-kargo-bilgi\">\r\n                                                            <span>");
#nullable restore
#line 94 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                             Write(TedarikciUrunleri.Sum(x=>x.Adet));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Ürün Kargoya Verildi</span>
                                                        </div>
                                                        <div>
                                                            <button class=""takip-info"">Kargo Durumu</button>
                                                        </div>
                                                    </div>

                                                </div>
                                                <div class=""scp-kargo-urunleri"">

");
#nullable restore
#line 104 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                     foreach(var urun in TedarikciUrunleri){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""scpb-kargo-urun-kutu"">
                                                            <div class=""pbiw-urun-kutu-resim"">
                                                                <img");
            BeginWriteAttribute("src", " src=\"", 6285, "\"", 6306, 1);
#nullable restore
#line 107 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
WriteAttributeValue("", 6291, urun.ResimLink, 6291, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6307, "\"", 6326, 1);
#nullable restore
#line 107 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
WriteAttributeValue("", 6313, urun.UrunAdi, 6313, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""product-box-image"">
                                                            </div>
                                                            <div class=""pbi-urun-kutu-bilgi"">
                                                                <a class=""text-decore-x"" href=""#"">
                                                                    <p class=""pn-urun-adi"">
                                                                        ");
#nullable restore
#line 112 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                   Write(urun.UrunAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                    </p>
                                                                    <div class=""ps-urun-toplam"">
                                                                        <span>Beden: Tek Ebat - ");
#nullable restore
#line 115 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                                           Write(urun.Adet);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Adet</span>\r\n                                                                        <span class=\"pbip-urun-kutu-tutar\">\r\n                                                                            ");
#nullable restore
#line 117 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                       Write(urun.Toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                        </span>
                                                                    </div>
                                                                </a>
                                                            </div>
                                                        </div>
");
#nullable restore
#line 123 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                  

                                                  

                                                   
                                                </div>

                                            </div>
                                        </div>
");
#nullable restore
#line 133 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                  

                                    <div class=""ods-siparis-toplam"">
                                        <div class=""asb-adres-bilgisi"">
                                            <div style=""height: 42px "" class=""h-siparis-detay-header"">
                                                <span>Fatura ve Teslimat Bilgisi</span>
                                            </div>
                                            <div class=""c-icerik"">
                                                <span>");
#nullable restore
#line 142 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                 Write(Siparisler.KullaniciAdresleri.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <span>");
#nullable restore
#line 143 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                 Write(Siparisler.KullaniciAdresleri.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                                <span>");
#nullable restore
#line 144 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                 Write(Siparisler.KullaniciAdresleri.Ilce);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 144 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                                       Write(Siparisler.KullaniciAdresleri.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </div>
                                        </div>
                                        <div class=""asb-adres-bilgisi"">
                                            <div style=""height: 42px "" class=""h-siparis-detay-header"">
                                                <span>Fatura ve Teslimat Bilgisi</span>
                                            </div>
                                            <div class=""c-icerik"">
                                                <div class=""pi-tutar-bilgi"">
                                                    <span class=""tit"">Ürün Toplamı</span>
                                                    <span class=""price-text"">");
#nullable restore
#line 154 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                        Write(ToplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ₺</span>
                                                </div>
                                                <hr class=""pih-tutar-hr"">
                                                <div class=""pi-tutar-bilgi"">
                                                    <span class=""tit"">Kargo Toplamı</span>
");
#nullable restore
#line 159 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                     foreach (var kargo in SiparisKargoBilgisi)
                                                    {
                                                        ToplamTutar+= kargo.KargoTutari;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                       <span class=\"price-text\">");
#nullable restore
#line 163 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                           Write(kargo.KargoTutari);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</span>\n");
#nullable restore
#line 164 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                                <hr class=""pih-tutar-hr"">
                                                <div class=""pi-tutar-bilgi"">
                                                    <span class=""tit-top""><b>Toplam</b></span>
                                                    <span class=""price-text orange"">");
#nullable restore
#line 169 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.WebSite\Views\Hesabim\SiparisBilgisi.cshtml"
                                                                               Write(ToplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ₺</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>

                        </div>

                    </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiparisBilgisiEntityleri> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
