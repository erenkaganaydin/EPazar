#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ecf25a48b2772039e16edb3a4b94692f75be4f"
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\_ViewImports.cshtml"
using EPazar.Mobil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\_ViewImports.cshtml"
using EPazar.Mobil.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ecf25a48b2772039e16edb3a4b94692f75be4f", @"/Views/UrunDetay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64de27e7bb5eb23441513778fa327f2dfbcf5cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UrunDetay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Urunler>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mobiladreslerim.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mobilurundetay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/w3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/UrunDetay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
  
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
            WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ecf25a48b2772039e16edb3a4b94692f75be4f6302", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ecf25a48b2772039e16edb3a4b94692f75be4f7421", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ecf25a48b2772039e16edb3a4b94692f75be4f8540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1ecf25a48b2772039e16edb3a4b94692f75be4f9660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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

<div class=""orders"">
    <div class=""favori-wrap"">
        <div class=""galery"">
        <div class=""foto"">
            <div class=""fotorama"" data-nav=""thumbs"" data-allowfullscreen=""native"">
");
#nullable restore
#line 49 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                 foreach (var item in Model.UrunResimleri)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("alt", " alt=\"", 2150, "\"", 2174, 2);
            WriteAttributeValue("", 2156, "Bigtarz-", 2156, 8, true);
#nullable restore
#line 51 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 2164, Model.Adi, 2164, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2175, "\"", 2196, 1);
#nullable restore
#line 51 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 2181, item.ResimLink, 2181, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 52 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        </div>

        <div class=""product-detay"">
            <div class=""product-detay-baslik"">
                <h1 class=""product-info-brand"">
                    <span class=""urun-ad"">Şile Bezi Elbise</span>
                </h1>
            </div>

        </div>
        <div class=""satici-bilgileri"">
            <div class=""satici-bilgeri-detay"">
                <span>Satıcı: </span><span>Bigtarz</span>
            </div>
        </div>
        <div class=""satici-bilgileri"">
            <div class=""satici-bilgeri-detay"">
                <i class=""fa fa-box""></i>   <span class=""termin-sure""> Tahmini kargoya Veriliş: </span> <span> Bigtarz</span>
            </div>
        </div>

");
#nullable restore
#line 76 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
          
            if(Model.ViewUrunOzellikleriAciklamali.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   <div class=""satici-bilgileri""  style=""margin-top: 25px; margin-bottom: 15px;"" >
                        <div class=""size-wrap"">
                            <div><h3 class=""header-size"">Renk</h3></div>
                            <!------->
                            <div");
            BeginWriteAttribute("class", " class=\"", 3356, "\"", 3364, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 84 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                 foreach (var item in UrunOzellikRenkleri){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("class", " class=\"", 3483, "\"", 3559, 2);
            WriteAttributeValue("", 3491, "urun-ozellikleri-renksecenegi", 3491, 29, true);
            WriteAttributeValue(" \r\n", 3520, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 86 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
 if(item == SecilenRenk){

#line default
#line hidden
#nullable disable
                WriteLiteral("secili\r\n");
#nullable restore
#line 87 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 3523, 36, false);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3560, "\"", 3604, 6);
            WriteAttributeValue("", 3567, "/UrunDetay/", 3567, 11, true);
#nullable restore
#line 87 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 3578, Model.Id, 3578, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3587, "/", 3587, 1, true);
#nullable restore
#line 87 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 3588, Model.Adi, 3588, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3598, "/", 3598, 1, true);
#nullable restore
#line 87 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 3599, item, 3599, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span class=\"urun-ozellikleri-renksecenegi-span\">\r\n                                            ");
#nullable restore
#line 89 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n                                    </a>\r\n");
#nullable restore
#line 92 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <!------->\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 97 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
            
                    
                    var RenkOzellikleri = Model.ViewUrunOzellikleriAciklamali.Where(x => x.RenkAdi == SecilenRenk).Select(x=> new { x.OzellikAdi ,x.OzellikStok });
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"satici-bilgileri\"  style=\"margin-top: 25px; margin-bottom: 15px;\" >\r\n                        <div class=\"size-wrap\">\r\n                            <div><h3 class=\"header-size\">Beden ");
#nullable restore
#line 103 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                                          Write(SecilenOzellik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n                            <!------->\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 4548, "\"", 4556, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 106 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                 foreach(var ozelikadlari in RenkOzellikleri)
                                 
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                     if(ozelikadlari.OzellikStok < 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div title=\"Stokta Yok\" class=\"v-item no-stock\">L</div>\r\n");
#nullable restore
#line 110 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 5005, "\"", 5081, 8);
            WriteAttributeValue("", 5012, "/UrunDetay/", 5012, 11, true);
#nullable restore
#line 113 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5023, Model.Id, 5023, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5032, "/", 5032, 1, true);
#nullable restore
#line 113 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5033, Model.Adi, 5033, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5043, "/", 5043, 1, true);
#nullable restore
#line 113 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5044, SecilenRenk, 5044, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5056, "/", 5056, 1, true);
#nullable restore
#line 113 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 5057, ozelikadlari.OzellikAdi, 5057, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                                            title=\"Beden Seçmek İçin Tıklayın\"");
            BeginWriteAttribute("class", " class=\"", 5163, "\"", 5378, 2);
            WriteAttributeValue("", 5171, "v-item", 5171, 6, true);
            WriteAttributeValue("  \r\n                                            ", 5177, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 115 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                             if(ozelikadlari.OzellikAdi == SecilenOzellik){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                WriteLiteral("secildi\r\n");
#nullable restore
#line 117 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 5225, 153, false);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 117 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                           Write(ozelikadlari.OzellikAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 118 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 \r\n                            </div>\r\n                            <!------->\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 125 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"       
        
       

        <div class=""urun-bilgileri"">
            <div class=""bilgiler-header"">
              <h3 class=""bilgiler-header-txt""> Ürün Açıklamaları </h3>
            </div>
            <div class=""urun-aciklama-text"">
                ");
#nullable restore
#line 137 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
           Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"fiyat-warp\">\r\n    <div class=\"fiyat-d\">\r\n        <div class=\"fiyat-t\">\r\n            <span>219.99₺</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"sepet-button\">\r\n");
#nullable restore
#line 150 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
          
            var Url = "";
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
         if(SecilenRenk != "")
        {
            Url = "/" + SecilenRenk;
            if (SecilenOzellik != "")
                Url = Url + "/" + SecilenOzellik;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 6412, "\"", 6455, 5);
            WriteAttributeValue("", 6419, "/SepeteEkle/", 6419, 12, true);
#nullable restore
#line 159 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 6431, Model.Id, 6431, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6440, "/", 6440, 1, true);
#nullable restore
#line 159 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 6441, Model.Adi, 6441, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunDetay\Index.cshtml"
WriteAttributeValue("", 6451, Url, 6451, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <button class=\"button-orange\">Sepete Ekle</button>\r\n        </a>\r\n    </div>\r\n</div>");
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