#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bfd5d1a8ded67cbe99f14134c31ef02ead81198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UrunOzellikleri_UrunBedenleri), @"mvc.1.0.view", @"/Views/UrunOzellikleri/UrunBedenleri.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfd5d1a8ded67cbe99f14134c31ef02ead81198", @"/Views/UrunOzellikleri/UrunBedenleri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UrunOzellikleri_UrunBedenleri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
 foreach (var item in Model)
{
    var Url = Context.Request.Query["Beden"];
     var deneme = HttpUtility.UrlDecode(item);
    var VarMi = Url.Contains(deneme);


#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 331, "\"", 386, 3);
            WriteAttributeValue("", 341, "BedenFilterEkle(\'", 341, 17, true);
#nullable restore
#line 16 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
WriteAttributeValue("", 358, Uri.EscapeUriString(item), 358, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 384, "\')", 384, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" style=\"display: flex;\"><input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 442, "\"", 458, 1);
#nullable restore
#line 16 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
WriteAttributeValue("", 452, VarMi, 452, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n        <span class=\"checkbox-span\">");
#nullable restore
#line 17 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n");
#nullable restore
#line 19 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\UrunOzellikleri\UrunBedenleri.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
