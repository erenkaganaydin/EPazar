#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6eb215f54af2c2fab0e3ac238bb6eec97519cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KategoriListesi_Listele), @"mvc.1.0.view", @"/Views/KategoriListesi/Listele.cshtml")]
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
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6eb215f54af2c2fab0e3ac238bb6eec97519cc", @"/Views/KategoriListesi/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    public class Views_KategoriListesi_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KategoriListesiEntityleri>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml"
  
    ViewData["Title"] = ViewData["Title"];

    var KategoriListesiBannerList = Model.KategoriListesiBanner;
    var KategoriListesiTopBannerlari = Model.KategoriListesiTopBanner;
    var AnasayfaSagBannerlar = Model.AnasayfaSagBannerList;
    var AnasayfaMiniBannerlar = Model.AnasayfaMiniBannerList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrap\">\r\n\r\n            ");
#nullable restore
#line 16 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml"
       Write(await Html.PartialAsync("_KategoriListesiTopBanner",KategoriListesiTopBannerlari));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"main-banner-show\">\r\n                <div class=\"banner-wrap\">\r\n                    <div class=\"component-list\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml"
                   Write(await Html.PartialAsync("_KategoriListesiBanner",KategoriListesiBannerList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"component-banner-list\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml"
                   Write(await Html.PartialAsync("_AnasayfaSagBanner",AnasayfaSagBannerlar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"banner-min\">\r\n                ");
#nullable restore
#line 31 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\KategoriListesi\Listele.cshtml"
           Write(await Html.PartialAsync("_AnasayfaMiniBanner",AnasayfaMiniBannerlar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KategoriListesiEntityleri> Html { get; private set; }
    }
}
#pragma warning restore 1591
