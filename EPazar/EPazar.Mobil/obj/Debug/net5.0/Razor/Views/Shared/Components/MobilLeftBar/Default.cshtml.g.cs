#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4280d48bf61560b8b936e2f797933485673e7b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MobilLeftBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MobilLeftBar/Default.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4280d48bf61560b8b936e2f797933485673e7b83", @"/Views/Shared/Components/MobilLeftBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64de27e7bb5eb23441513778fa327f2dfbcf5cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_MobilLeftBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NavbarEntityleri>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sub-item-li"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
  
    var AnaKategorilerList = Model.AnaKategorilerList;
    var KategorilerList = Model.KategorilerList;
    var AltKategorilerList = Model.AltKategorilerList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
  
    var SeciliSeciliAnaKategoriId = Context.Request.RouteValues.FirstOrDefault(x=> x.Key == "AnaKategoriId").Value;
    var SecilenSeciliAnaKategoriId = "";
    if(SeciliSeciliAnaKategoriId != null)
        SecilenSeciliAnaKategoriId= SeciliSeciliAnaKategoriId.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
.accordion {
  background-color: #ffa50012;
  color: #444;
  cursor: pointer;
  padding: 18px;
  width: 100%;
  border: none;
  text-align: left;
  outline: none;
  font-size: 15px;
  transition: 0.4s;
  display:flex;
  justify-content: space-between;
}

.accordion {
    float:right;
}
.accordion a{
    text-decoration: underline!important;
    color: black;
}

.active, .accordion:hover {
  background-color: #ccc; 
}

.panel {
  padding: 0 1px;
  display: none;
  background-color: white;
  overflow: hidden;
}
</style>
<!------ Include the above in your HEAD tag 
<div class=""container"">
  <div class=""accordion"" id=""accordion2"">
  
    <div class=""accordion-group"">
      <div class=""accordion-heading"">
        <a class=""accordion-toggle"" data-toggle=""collapse"" data-parent=""#accordion2"" href=""#collapseTwo""> Collapsible Group Item #2 </a>
      </div>
      <div id=""collapseTwo"" class=""accordion-body collapse"">
        <div class=""accordion-inner""> Anim pariat");
            WriteLiteral(@"ur cliche... </div>
      </div>
    </div>

  </div>
</div>
-->
<nav class=""w3-sidenav w3-white w3-animate-left"" style=""display:none;"">
    <div class=""sidenav-logo"">
        <a href=""/Home"">
            <img class=""sidenav-logo-img"" src=""https://www.bigtarz.com/img/Bigtarz.png"" alt=""Bigtarz Logo"">
        </a>
    </div>
");
#nullable restore
#line 76 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
     foreach (var AnaKategoriItem in AnaKategorilerList)
    {
        var Kategorileri = KategorilerList.Where(x=>x.AnaKategoriId == AnaKategoriItem.Id).ToList().Take(6); 
        
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
         if(AnaKategoriItem.Id == 1 || AnaKategoriItem.Id == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"accordion\"> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4280d48bf61560b8b936e2f797933485673e7b837378", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 84 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
           Write(AnaKategoriItem.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2269, "~/KategoriListesi/Listele/", 2269, 26, true);
#nullable restore
#line 83 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 2295, AnaKategoriItem.Id, 2295, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2314, "/", 2314, 1, true);
#nullable restore
#line 83 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 2315, Html.Raw(AnaKategoriItem.Ad), 2315, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2344, "?Tumu=1", 2344, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <span>⬇️</span>\r\n            </button>\r\n");
#nullable restore
#line 88 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"accordion\"> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4280d48bf61560b8b936e2f797933485673e7b8310046", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 92 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
               Write(AnaKategoriItem.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2563, "~/Urunler/Liste/", 2563, 16, true);
#nullable restore
#line 91 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 2579, AnaKategoriItem.Id, 2579, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2598, "/", 2598, 1, true);
#nullable restore
#line 91 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 2599, Html.Raw(AnaKategoriItem.Ad), 2599, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2628, "?Tumu=1", 2628, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <span>⬇️</span>\r\n            </button>\r\n");
#nullable restore
#line 96 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"panel\">\r\n");
#nullable restore
#line 98 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
         foreach(var KategoriItem in Kategorileri)
        {
            var AltKategorileri = AltKategorilerList.Where(x=>x.KategoriId == KategoriItem.Id).ToList(); 
           

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"accordion\" style=\"background-color: #ffa50029\"> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4280d48bf61560b8b936e2f797933485673e7b8313176", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 104 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
           Write(KategoriItem.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 9, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3084, "~/Urunler/Liste/", 3084, 16, true);
#nullable restore
#line 103 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3100, KategoriItem.AnaKategoriId, 3100, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3127, "/", 3127, 1, true);
#nullable restore
#line 103 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3128, Html.Raw(AnaKategoriItem.Ad), 3128, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3157, "/", 3157, 1, true);
#nullable restore
#line 103 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3158, KategoriItem.Id, 3158, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3174, "/", 3174, 1, true);
#nullable restore
#line 103 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3175, Html.Raw(KategoriItem.Ad), 3175, 26, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3201, "/?Tumu=1", 3201, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <span>⬇️</span>\r\n            </button>\r\n            <div class=\"panel\">\r\n");
#nullable restore
#line 109 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
             foreach(var AltKategoriItem in AltKategorileri)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4280d48bf61560b8b936e2f797933485673e7b8316554", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 112 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
               Write(AltKategoriItem.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 13, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3461, "~/Urunler/Liste/", 3461, 16, true);
#nullable restore
#line 111 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3477, KategoriItem.AnaKategoriId, 3477, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3504, "/", 3504, 1, true);
#nullable restore
#line 111 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3505, Html.Raw(AnaKategoriItem.Ad), 3505, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3534, "/", 3534, 1, true);
#nullable restore
#line 111 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3535, KategoriItem.Id, 3535, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3551, "/", 3551, 1, true);
#nullable restore
#line 111 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3552, Html.Raw(KategoriItem.Ad), 3552, 26, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3578, "/", 3578, 1, true);
#nullable restore
#line 111 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3579, AltKategoriItem.Id, 3579, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3598, "/", 3598, 1, true);
#nullable restore
#line 111 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
AddHtmlAttributeValue("", 3599, Html.Raw(AltKategoriItem.Ad), 3599, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3628, "?Tumu=1", 3628, 7, true);
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
#line 114 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div>\r\n");
#nullable restore
#line 116 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 118 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\MobilLeftBar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</nav>
<!---->


<script>
var acc = document.getElementsByClassName(""accordion"");
var i;

for (i = 0; i < acc.length; i++) {
  acc[i].addEventListener(""click"", function() {
    this.classList.toggle(""active"");
    var panel = this.nextElementSibling;
    if (panel.style.display === ""block"") {
      panel.style.display = ""none"";
    } else {
      panel.style.display = ""block"";
      
    }
  });
}
</script>");
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
