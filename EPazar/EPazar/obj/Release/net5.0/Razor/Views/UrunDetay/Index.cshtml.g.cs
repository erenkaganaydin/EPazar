#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e42c2c61adda30a96e1d91a37336ebd87e1ae112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UrunDetay_Index), @"mvc.1.0.view", @"/Views/UrunDetay/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\_ViewImports.cshtml"
using EPazar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\_ViewImports.cshtml"
using EPazar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42c2c61adda30a96e1d91a37336ebd87e1ae112", @"/Views/UrunDetay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UrunDetay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Urunler>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/UrunDetay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
  
    var UrunOzellikRenkleri = Model.ViewUrunOzellikleriAciklamali.GroupBy(x => x.RenkAdi).Select(x=> x.Key);

    var SeciliRenk = Context.Request.RouteValues.FirstOrDefault(x=> x.Key == "SeciliRenk").Value;
    var SecilenRenk = "";
    if(SeciliRenk != null)
        SecilenRenk= SeciliRenk.ToString();

    var SeciliOzellik = Context.Request.RouteValues.FirstOrDefault(x=> x.Key == "SeciliOzellik").Value;
    var SecilenOzellik = "";
    if (SeciliOzellik != null)
        SecilenOzellik = SeciliOzellik.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e42c2c61adda30a96e1d91a37336ebd87e1ae1124946", async() => {
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
 <!-- jQuery 1.8 or later, 33 KB -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>

<!-- Fotorama from CDNJS, 19 KB -->
<link  href=""https://cdnjs.cloudflare.com/ajax/libs/fotorama/4.6.4/fotorama.css"" rel=""stylesheet"">
<script src=""https://cdnjs.cloudflare.com/ajax/libs/fotorama/4.6.4/fotorama.js""></script>

            <div class=""Urun-Navigation"">
                <a href=""#""> Anasayfa </a>
                <a href=""#"" class=""urun-navigation-arrow""> > </a>
                <a href=""#""> Kadın </a>
                <a href=""#"" class=""urun-navigation-arrow""> > </a>
                <a href=""#"" > Giyim </a>
                <a href=""#"" class=""urun-navigation-arrow""> > </a>
                <a href=""#""> Jean </a>
            </div>

            <div class=""flex-container"">
                <div class=""urun-container"">
                    <div>
                        <div class=""product-images"">
                            <div class=""product-image"">
  ");
            WriteLiteral("                              <div class=\"foto\">\r\n                                    <div class=\"fotorama\" data-nav=\"thumbs\" data-allowfullscreen=\"native\">\r\n");
#nullable restore
#line 45 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                         foreach (var item in Model.UrunResimleri)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 2018, "\"", 2042, 2);
            WriteAttributeValue("", 2024, "Bigtarz-", 2024, 8, true);
#nullable restore
#line 47 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 2032, Model.Adi, 2032, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2043, "\"", 2064, 1);
#nullable restore
#line 47 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 2049, item.ResimLink, 2049, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 48 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""product-sag"">
                        <div class=""product-header"">
                            <div class=""flex"">
                                <div class=""product-header-item"">
                                    <div>
                                        <h1 class=""product-h1"">");
#nullable restore
#line 59 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                          Write(Model.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    </div>
                                    <div class=""product-marka"">
                                        <span>Satıcı:</span><a class=""h1-blue"" href=""#"">Bigtarz</a>
                                    </div>
                                    <div class=""urun-fiyat-container"">
                                        <div class=""urun-fiyat-bx"">
                                            <div class=""urun-fiyat-dsc"">
                                                <div class=""urun-fiyat-dsc-column"">
                                                    <span class=""urun-eski-fiyat"">");
#nullable restore
#line 68 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                                             Write(Model.EskiFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</span>\r\n                                                    <span class=\"urun-fiyat\">");
#nullable restore
#line 69 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                                        Write(Model.EskiFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₺</span>
                                                </div>
                                            </div>
                                            <div class=""ayrac""></div>
                                            <div class=""urun-fiyat-dsc"">
                                                <div class=""urun-fiyat-dsc-column"">
                                                    <div style=""display:flex; "">
                                                        <span class=""urun-son-fiyat"">");
#nullable restore
#line 76 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                                                Write(Model.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""ozellik-button-div"">
");
#nullable restore
#line 86 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                          
                            if(Model.ViewUrunOzellikleriAciklamali.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""urun-ozellikleri"">
                                    <section class=""urun-ozellikleri-section"">
                                        <div class=""urun-ozellikleri-renk-title"" >
                                            <h2 class=""urun-ozellikleri-renk-h2"">Renk</h2>
                                        </div>
                                        <div class=""urun-renk-liste-div"">
                                            <div class=""urun-renk-liste"">
");
#nullable restore
#line 96 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                 foreach (var item in UrunOzellikRenkleri){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("class", " class=\"", 5150, "\"", 5455, 2);
            WriteAttributeValue("", 5158, "urun-ozellikleri-renksecenegi", 5158, 29, true);
            WriteAttributeValue("  ", 5187, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 97 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                                                              if(item == SecilenRenk){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                                                                    ");
                WriteLiteral("secili\r\n");
#nullable restore
#line 99 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                                                                                }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 5189, 266, false);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 5456, "\"", 5500, 6);
            WriteAttributeValue("", 5463, "/UrunDetay/", 5463, 11, true);
#nullable restore
#line 99 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5474, Model.Id, 5474, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5483, "/", 5483, 1, true);
#nullable restore
#line 99 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5484, Model.Adi, 5484, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5494, "/", 5494, 1, true);
#nullable restore
#line 99 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5495, item, 5495, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <span class=\"urun-ozellikleri-renksecenegi-span\">\r\n                                                            ");
#nullable restore
#line 101 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </span>\r\n                                                    </a>\r\n");
#nullable restore
#line 104 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </section>
                                </div>
                                    <div class=""urun-ozellikleri"">
");
#nullable restore
#line 110 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                          
                                            var RenkOzellikleri = Model.ViewUrunOzellikleriAciklamali.Where(x => x.RenkAdi == SecilenRenk).Select(x=> new { x.OzellikAdi ,x.OzellikStok });
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""urun-size-title"">
                                            <span class=""urun-size-title-text"">
                                                Beden :
                                                <span class=""uurn-size-title-secili-text"">");
#nullable restore
#line 116 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                                                     Write(SecilenOzellik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </span>\r\n                                        </div>\r\n                                        <div class=\"variants\">\r\n");
#nullable restore
#line 120 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                             foreach(var ozelikadlari in RenkOzellikleri)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                 if(ozelikadlari.OzellikStok < 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div title=\"Stokta Yok\" class=\"v-item no-stock\">L</div>\r\n");
#nullable restore
#line 124 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7413, "\"", 7489, 8);
            WriteAttributeValue("", 7420, "/UrunDetay/", 7420, 11, true);
#nullable restore
#line 127 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 7431, Model.Id, 7431, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7440, "/", 7440, 1, true);
#nullable restore
#line 127 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 7441, Model.Adi, 7441, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7451, "/", 7451, 1, true);
#nullable restore
#line 127 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 7452, SecilenRenk, 7452, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7464, "/", 7464, 1, true);
#nullable restore
#line 127 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 7465, ozelikadlari.OzellikAdi, 7465, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                                                        title=\"Beden Seçmek İçin Tıklayın\"");
            BeginWriteAttribute("class", " class=\"", 7583, "\"", 7834, 2);
            WriteAttributeValue("", 7591, "v-item", 7591, 6, true);
            WriteAttributeValue("  \r\n                                                        ", 7597, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 129 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                         if(ozelikadlari.OzellikAdi == SecilenOzellik){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            ");
                WriteLiteral("secildi\r\n");
#nullable restore
#line 131 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 7657, 177, false);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 131 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                       Write(ozelikadlari.OzellikAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 132 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                               \r\n                                            \r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 138 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"urun-buttonlari\">\r\n                          \r\n");
#nullable restore
#line 142 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                  var Url = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                                 if(SecilenRenk != "")
                                {
                                    Url = "/" + SecilenRenk;
                                    if (SecilenOzellik != "")
                                        Url = Url + "/" + SecilenOzellik;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 8708, "\"", 8751, 5);
            WriteAttributeValue("", 8715, "/SepeteEkle/", 8715, 12, true);
#nullable restore
#line 149 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 8727, Model.Id, 8727, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8736, "/", 8736, 1, true);
#nullable restore
#line 149 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 8737, Model.Adi, 8737, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 8747, Url, 8747, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""sepete-ekle"">
                                    <button class=""sepete-ekle"" type=""button"" style=""color:#fff"">Sepete Ekle</button>
                                </a>
                                
                                <div class=""favori-button"">
                                    <button class=""favori"">
                                        <!--Favorideyse ==> favoride eklenip , -regular kalakacak-->
                                        <i class=""fa-regular favoride fa-heart kalp-icon""></i>
                                    </button>
                                </div>
                            </div>
                            <div class=""teslimat"">
                                <div>
                                    <div  class=""tahmini-text"">Tahmini Kargoya Verilme Tarihi: <span class=""tahmini-gun-value"">3</span> gün içinde</div>
                                </div>
                            </div>
                        </div>
              ");
            WriteLiteral(@"          <div class=""urun-bilgiler"">
                            <div class=""urun-bilgiler-title"">
                                Ürün Bilgileri
                            </div>
                            <div class=""urun-bilgileri-aciklama"">
                                <ul class=""urun-bilgileri-ul"">
                                    <li>15 gün içinde ücretsiz iade yapabilirisniz. Detaylı bilgi için whatsapp üzerinden iletişime geçmeniz yeterlidir.</li>
                                    <li>Bu Ürün Bigtarz Tedarikcisi Bigatu tarafından gönderilecektir.</li>
                                </ul>
                                <div class=""urun-tedarikci-detayi"">
                                    <a class=""tedarikci-detay-button"" href=""#UrunTedarikciDetayi"">Ürün Tedarikçi Detayı İçin Tıklayın.</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""uru");
            WriteLiteral(@"n-yan"">
                    <div class=""panel kampanyalar"">
                        <h1 class=""panel-title"">Ürün Fırsatları</h1>
                        <div class=""panel-satir"">
                            <a href=""#"" class=""flex"">
                                <i class=""i-kampanya fa-solid fa-barcode""></i>
                                <span class=""kampanya-adi"">50₺ ve Üzeri Kargo Bedava </span>
                            </a>
                        </div>
                    </div>

                    <div class=""panel kampanyalar mt-35"">
                        <h1 class=""panel-title""> <i class=""i-kampanya fa-solid fa-shop""></i> Bigatu</h1>
                        <div class=""panel-satir"">
                            <a href=""#"" class=""flex"">
                                <i class=""i-kampanya fa-solid fa-check""></i>
                                <span class=""kampanya-adi"">Bu satıcı Bigtarz tarafından önerilyor.</span>
                            </a>
                        </");
            WriteLiteral(@"div>
                        <div class=""panel-satir"">
                            <a href=""#"" class=""flex"">
                                <i class=""i-kampanya fa-solid fa-box""></i>
                                <span class=""kampanya-adi"">Bu satıcının tüm ürünleri bigtarz tarafından kontrol edilmektedir.</span>
                            </a>
                        </div>
                    </div>

                </div>
            </div>

                 ");
#nullable restore
#line 212 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
            Write(await Component.InvokeAsync("UrunDetayOneriUrunler",@Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            

            <div id=""UrunTedarikciDetayi"" class=""UrunTedarikciDetayi"">
                <h2 class=""Urun-Detay-Title"">Ürün Tedarikci Bilgileri</h2>
                <div class=""urun-tedarikci-detay-container"">
                    <div class=""flex-container"">
                        <img class=""urun-tedarikci-detay-img""");
            BeginWriteAttribute("alt", " alt=\"", 12706, "\"", 12730, 2);
            WriteAttributeValue("", 12712, "Bigtarz-", 12712, 8, true);
#nullable restore
#line 220 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 12720, Model.Adi, 12720, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 12731, "\"", 12775, 1);
#nullable restore
#line 220 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 12737, Model.UrunResimleri.First().ResimLink, 12737, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 12776, "\"", 12800, 2);
            WriteAttributeValue("", 12782, "Bigtarz-", 12782, 8, true);
#nullable restore
#line 220 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 12790, Model.Adi, 12790, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div>\r\n                            ");
#nullable restore
#line 222 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\UrunDetay\Index.cshtml"
                       Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Urunler> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
