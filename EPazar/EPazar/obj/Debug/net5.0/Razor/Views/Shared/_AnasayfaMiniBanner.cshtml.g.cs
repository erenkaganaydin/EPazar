#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2252a6603d25c563d17f72182abbeaeae1c28a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AnasayfaMiniBanner), @"mvc.1.0.view", @"/Views/Shared/_AnasayfaMiniBanner.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2252a6603d25c563d17f72182abbeaeae1c28a1f", @"/Views/Shared/_AnasayfaMiniBanner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AnasayfaMiniBanner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnasayfaMiniBanner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <article class=\"comp-min-banner\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 172, "\"", 189, 1);
#nullable restore
#line 8 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml"
WriteAttributeValue("", 179, item.Link, 179, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"campain\">\r\n                        <span class=\"image-container\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 297, "\"", 314, 1);
#nullable restore
#line 10 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml"
WriteAttributeValue("", 303, item.Image, 303, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 315, "\"", 321, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </span>\r\n                        <summary class=\"campaign-summary\">\r\n                            <span class=\"name\">\r\n                                ");
#nullable restore
#line 14 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml"
                           Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </summary>\r\n                    </a>\r\n                </article>\r\n");
#nullable restore
#line 19 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\_AnasayfaMiniBanner.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnasayfaMiniBanner>> Html { get; private set; }
    }
}
#pragma warning restore 1591