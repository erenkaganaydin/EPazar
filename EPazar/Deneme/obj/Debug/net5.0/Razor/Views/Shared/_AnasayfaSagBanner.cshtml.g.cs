#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\_AnasayfaSagBanner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a55c6aea94c6626aa68bc11d21c27c5e89d916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AnasayfaSagBanner), @"mvc.1.0.view", @"/Views/Shared/_AnasayfaSagBanner.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\_AnasayfaSagBanner.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a55c6aea94c6626aa68bc11d21c27c5e89d916", @"/Views/Shared/_AnasayfaSagBanner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AnasayfaSagBanner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnasayfaSagBanner>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\_AnasayfaSagBanner.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"banner-wrap\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 156, "\"", 164, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 186, "\"", 203, 1);
#nullable restore
#line 9 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\_AnasayfaSagBanner.cshtml"
WriteAttributeValue("", 193, item.Link, 193, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"margin-bottom: 15px;visibility: visible;height: auto;display: block;width: 340px;height: 333px; background-repeat: no-repeat;background-attachment: fixed;background-position: center;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 419, "\"", 436, 1);
#nullable restore
#line 10 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\_AnasayfaSagBanner.cshtml"
WriteAttributeValue("", 425, item.Image, 425, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"");
            BeginWriteAttribute("alt", " alt=\"", 456, "\"", 462, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\_AnasayfaSagBanner.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnasayfaSagBanner>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
