#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_LayoutDesktop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a6d15effac804fb5fd5e764267a7ebba744649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutDesktop), @"mvc.1.0.view", @"/Views/Shared/_LayoutDesktop.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a6d15effac804fb5fd5e764267a7ebba744649", @"/Views/Shared/_LayoutDesktop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutDesktop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css?Id=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/BigtarzLogo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Bigtarz Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a6d15effac804fb5fd5e764267a7ebba7446495215", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\"\r\n          content=\"width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16a6d15effac804fb5fd5e764267a7ebba7446495725", async() => {
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
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css\">\r\n    <title>");
#nullable restore
#line 10 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_LayoutDesktop.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 513, "\"", 544, 1);
#nullable restore
#line 11 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_LayoutDesktop.cshtml"
WriteAttributeValue("", 523, ViewData["MetaDesc"], 523, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a6d15effac804fb5fd5e764267a7ebba7446498421", async() => {
                WriteLiteral(@"
<!--#region container-->
<div class=""container"">
    <!--#region TopHeader-->
    <div class=""top-header"">
        <ul>
            <li><a class=""nodecor"" href=""#"">Mağaza Aç</a></li>
            <li><a class=""nodecor"" href=""#"">Hakkımızda</a></li>
            <li><a class=""nodecor"" href=""#"">Kampanyalar</a></li>
        </ul>
    </div>
    <!--#region TopHeader-->
    <div class=""sticky-header"">
        <div class=""wrapper"">
            <div class=""header"">
                <div class=""header-logo"">
                    <a href=""index.html"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16a6d15effac804fb5fd5e764267a7ebba7446499263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"Arama\">\r\n                    <div class=\"search-box-container\"><input class=\"search-box\" type=\"text\" tabindex=\"1\" placeholder=\"Kategori, ürün veya markayı yazınız\" maxlength=\"50\" autocomplete=\"off\"");
                BeginWriteAttribute("value", " value=\"", 1448, "\"", 1456, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""search-icon""></i></div>
                </div>
                <div class=""header-top-navigator"">
                    <div class=""header-top-navigator-block"">
                        <div class=""top-navigator-wrap"">
                            <div class=""top-navigator-item user-nav""><i class=""far fa-user""></i></i><div>Hesabım</div></div>
                            <div class=""top-navigator-item""><i class=""fas fa-shopping-basket""></i><a class=""nodecor"" href=""#"">Sepetim</a></div>
                            <div class=""top-navigator-item""><i class=""far fa-heart""></i><a class=""nodecor"" href=""#"">Favoriler</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    ");
#nullable restore
#line 46 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_LayoutDesktop.cshtml"
Write(await Component.InvokeAsync("DesktopNavbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"body-main\">\r\n            ");
#nullable restore
#line 49 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_LayoutDesktop.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
       </div>
</div>

<div class=""yukari-cik"">
    <i class=""fas fa-arrow-up""></i><span>Yukarı Çık</span>
</div>

<div class=""footer"">
    <div class=""footer-wrap"">

        <div>
            <a href=""#""><h4>Bigtarz</h4></a>
            <ul>
                <li><a href=""#"">Hakkımızda</a></li>
                <li><a href=""#"">Ekibimize Katıl</a></li>
                <li><a href=""#"">İletişim</a></li>
            </ul>
            <div>
                <div>
                    <ul>
                        <li><p class=""footer-title"">Güvenle Kullanın</p></li>
                        <div id=""guvenle-kullanin"" class=""guvenle-kullanin"">
                            <div id=""troy"" class=""troy""></div>
                            <div id=""master-card"" class=""master-card""></div>
                            <div id=""visa""></div>
                        </div>
                    </ul>
                </div>
            </div>
        </div>

        <div>
            <ul>
              ");
                WriteLiteral(@"  <a href=""#""><h4>Hakkımızda</h4></a>
                <li>Biz Kimiz</li>
                <li>Kariyer</li>
                <li>Whatsapp</li>
            </ul>
        </div>

        <div>
            <ul>
                <li>
                    <p class=""footer-title"">Mobil Uygulamalar</p>
                </li>
                <li>
                    <div>
                        <h5>YAKINDA...</h5>
                    </div>
                </li>
            </ul>
        </div>

        <div>
            <ul>
                <a href=""#""><h4>Sosyal Medya</h4></a>
                <div id=""social"" class=""social"">
                    <a href=""#"" class=""facebook-image""><img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Instagram_icon.png/1024px-Instagram_icon.png""");
                BeginWriteAttribute("alt", " alt=\"", 4174, "\"", 4180, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a href=\"#\" class=\"facebook-image\"><img src=\"https://icons-for-free.com/iconfiles/png/512/tube+video+you+youtube+icon-1320185153402885670.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4350, "\"", 4356, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                </div>
            </ul>
        </div>
    </div>
</div>

<div class=""footer-info"">
    <div class=""footer-info-wrap"">
        <div class=""footer-info-left-text"">
            ©2022 SRK YILMAZ LIMITED SIRKET ÜRÜNÜDÜR.
        </div>
        <div class=""footer-info-ul"">
            <ul>
                <li><a class=""footer-info-ul-li-item"" href=""#"">GİZLİLİK POLİTİKASI</a></li>
                <li><a class=""footer-info-ul-li-item"" href=""#"">SRK YILMAZ LIMITED</a></li>
                <li><a class=""footer-info-ul-li-item"" href=""#"">VERİ GİZLİLİĞİ</a></li>
            </ul>
        </div>
    </div>
</div>
<!--#region container-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591