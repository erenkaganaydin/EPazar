#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb9d3565c2722f1d62a55df7282ed0497f5e5b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UrunlerRenkler_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UrunlerRenkler/Default.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb9d3565c2722f1d62a55df7282ed0497f5e5b5", @"/Views/Shared/Components/UrunlerRenkler/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba155f971346ec4b387187d901daba4031f007de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UrunlerRenkler_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>


<script type=""text/javascript"">
    function RenkAra(value){
        $.ajax({
        url: ""/UrunOzellikleri/Renkler/""+value,
        data: {
        },
        type: ""GET"",
        dataType : ""html"",
        success: function (data){
                console.log(data);
                $('#renklerDivi').html(data);
                //$('#showresults').html($('#showresults',data).html());
                // similar to $(data).find('#showresults')
            }
        });
    }
  
</script>
<input type=""text""");
            BeginWriteAttribute("value", " value=\"", 783, "\"", 791, 0);
            EndWriteAttribute();
            WriteLiteral(" onkeyup=\"RenkAra(this.value)\" id=\"inputRenkAdi\" name=\"RenkAdi\" style=\"border: 1px solid gray;border-radius: 13px;margin-bottom: 9px;\"/>\r\n<div id=\"renklerDivi\">\r\n");
#nullable restore
#line 29 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
     foreach (var item in Model)
    {
        var Url = Context.Request.Query["Renk"];
        var deneme = HttpUtility.UrlDecode(item);
        var VarMi = Url.Contains(deneme);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1151, "\"", 1205, 3);
            WriteAttributeValue("", 1161, "RenkFilterEkle(\'", 1161, 16, true);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
WriteAttributeValue("", 1177, Uri.EscapeUriString(item), 1177, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1203, "\')", 1203, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1234, 1);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
WriteAttributeValue("", 1213, Context.Request.Path, 1213, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: flex;\"><input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 1281, "\"", 1297, 1);
#nullable restore
#line 35 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
WriteAttributeValue("", 1291, VarMi, 1291, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n            <span class=\"checkbox-span\">");
#nullable restore
#line 36 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n");
#nullable restore
#line 38 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\Deneme\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<script>
    function RenkFilterEkle(BedenBilgisi){
        let text = window.location.href;
        if(text.search(BedenBilgisi) != -1)      
        {
            window.location.href = text.replace(""&Renk=""+BedenBilgisi, """");
            return;
        }
        else{
            window.location.href =  window.location.href+""&Renk=""+BedenBilgisi;
            return;
        }
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
