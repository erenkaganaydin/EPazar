#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b54fcc19b30e6a092576a9da8a755279b7d2005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UrunOzellikleri_UrunRenkleri), @"mvc.1.0.view", @"/Views/UrunOzellikleri/UrunRenkleri.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b54fcc19b30e6a092576a9da8a755279b7d2005", @"/Views/UrunOzellikleri/UrunRenkleri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64de27e7bb5eb23441513778fa327f2dfbcf5cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UrunOzellikleri_UrunRenkleri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
 foreach (var item in Model)
{
    var Url = Context.Request.Query["Renk"];
    var VarMi = Url.Contains(item);


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"secili-filtre\">\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 298, "\"", 331, 3);
            WriteAttributeValue("", 308, "RenkFilterEkle(\'", 308, 16, true);
#nullable restore
#line 15 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
WriteAttributeValue("", 324, item, 324, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 329, "\')", 329, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" style=\"display: flex;\">\r\n");
#nullable restore
#line 16 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
             if (@VarMi)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>✅</span>\r\n");
#nullable restore
#line 19 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"checkbox-span\">");
#nullable restore
#line 20 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\UrunOzellikleri\UrunRenkleri.cshtml"
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