#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae0a81114d40fb43214b1c0e2fc19f8d2b44124f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UrunlerFilter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UrunlerFilter/Default.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae0a81114d40fb43214b1c0e2fc19f8d2b44124f", @"/Views/Shared/Components/UrunlerFilter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UrunlerFilter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
 foreach (var item in Model)
{
    var Url = Context.Request.Query["Beden"];
    var VarMi = Url.Contains(item);


#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 245, "\"", 279, 3);
            WriteAttributeValue("", 255, "BedenFilterEkle(\'", 255, 17, true);
#nullable restore
#line 13 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
WriteAttributeValue("", 272, item, 272, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 277, "\')", 277, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" style=\"display: flex;\"><input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 335, "\"", 351, 1);
#nullable restore
#line 13 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
WriteAttributeValue("", 345, VarMi, 345, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n        <span class=\"checkbox-span\">");
#nullable restore
#line 14 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n");
#nullable restore
#line 16 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar\Views\Shared\Components\UrunlerFilter\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function BedenFilterEkle(BedenBilgisi){
        let text = window.location.href;
        text = text.replace("" "","""");

        text =text.replace(""&Beden=""+BedenBilgisi, """"); 
        text = text.replace(""%20"","" "");
        text = text.replace(""%C5"",""Ş"");
        text = text.replace(""%9E"","""");
        if(text.search(BedenBilgisi) != -1)      
        {
            window.location.href = text.replace(""&Beden=""+BedenBilgisi, """");
            return;
        }
        window.location.href =  window.location.href+""&Beden=""+BedenBilgisi;
        return;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
