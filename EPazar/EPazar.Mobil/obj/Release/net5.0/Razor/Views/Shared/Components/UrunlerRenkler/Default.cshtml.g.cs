#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa3314adc7fcadfe47f879b21ccc75ca3ed5808"
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa3314adc7fcadfe47f879b21ccc75ca3ed5808", @"/Views/Shared/Components/UrunlerRenkler/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64de27e7bb5eb23441513778fa327f2dfbcf5cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UrunlerRenkler_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>


<script type=""text/javascript"">
    function RenkAra(value){
        console.log(value);
            
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
            BeginWriteAttribute("value", " value=\"", 775, "\"", 783, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Renklerde Arayın..."" onkeyup=""RenkAra(this.value)"" id=""inputRenkAdi"" name=""RenkAdi"" style=""border: 1px solid gray;border-radius: 13px;margin-bottom: 9px;width: 96%;text-align: center;margin-left: 8px;height: 39px;""/>
<div id=""renklerDivi"">
");
#nullable restore
#line 30 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
 foreach (var item in Model)
{
    var Url = Context.Request.Query["Renk"];
    var VarMi = Url.Contains(item);


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"secili-filtre\">\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1201, "\"", 1234, 3);
            WriteAttributeValue("", 1211, "RenkFilterEkle(\'", 1211, 16, true);
#nullable restore
#line 36 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
WriteAttributeValue("", 1227, item, 1227, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1232, "\')", 1232, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" style=\"display: flex;\">\r\n");
#nullable restore
#line 37 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
             if (@VarMi)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>✅</span>\r\n");
#nullable restore
#line 40 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"checkbox-span\">");
#nullable restore
#line 41 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\EPazar.Mobil\Views\Shared\Components\UrunlerRenkler\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script>
    function RenkFilterEkle(BedenBilgisi){
        BedenBilgisi = BedenBilgisi.replace("" "",""%20"");
        let text = window.location.href;
        text = text.replace(""%C5"",""Ş"");
        text = text.replace(""%9E"","""");
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
