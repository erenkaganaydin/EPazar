#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c21f410afb1b4433ff3ac3bc4d28ad9426d254e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Siparis_Index), @"mvc.1.0.view", @"/Views/Siparis/Index.cshtml")]
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
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\_ViewImports.cshtml"
using BigtarzPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\_ViewImports.cshtml"
using BigtarzPanel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
using EPazar.Entity.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c21f410afb1b4433ff3ac3bc4d28ad9426d254e", @"/Views/Siparis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389de6e98a8cf3b27c3eae541a0062c637640677", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Siparis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Siparis>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"container-fluid page-body-wrapper\">\r\n    <div class=\"main-panel\">\r\n        <div class=\"content-wrapper pb-0\">\r\n            <div class=\"page-header flex-wrap\">\r\n                <div class=\"header-left\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c21f410afb1b4433ff3ac3bc4d28ad9426d254e4427", async() => {
                WriteLiteral(@"
                        <input type=""text"" name=""SiparisNumarasi"" placeholder=""Sipariş Numarası"" class=""btn btn-outline-secondary mb-2 mb-md-0"" />
                        <input type=""text"" name=""SiparisDurumAdi"" placeholder=""Sipariş Durumu"" class=""btn btn-outline-success mb-2 mb-md-0"" />
                        <input type=""text"" name=""MusteriAd"" placeholder=""Müşteri Ad"" class=""btn btn-outline-dribbble mb-2 mb-md-0"" />
                        <input type=""text"" name=""MusteriSoyad"" placeholder=""Müşteri Soyad"" class=""btn btn-outline-dribbble mb-2 mb-md-0"" />
                        <input type=""date"" name=""SiparisTarihi"" placeholder=""Sipariş Tarihi [ 2022-05-07 ]"" class=""btn btn-outline-info mb-2 mb-md-0"" />
                        <button type=""submit"" class=""btn btn-facebook mb-2 mb-md-0"">Arama Yap</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""header-right d-flex flex-wrap mt-md-2 mt-lg-0"">
                    <div class=""d-flex align-items-center"">
                        <a href=""#"">
                        </a>
                    </div>
                </div>
            </div>

            <div style=""padding: 0;"" class=""col-lg-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        </p>
                        <div class=""table-responsive"">
                            <table class=""table table-striped table-hover"">
                                <thead>
                                    <tr>
                                        <th>Sipariş Numarası</th>
                                        <th>Ad Soyad</th>
                                        <th>Toplam Tutar</th>
                                        <th>Sipariş Tarihi</th>
                                        <th>Ödeme Durum");
            WriteLiteral(@"u</th>
                                        <th>Sipariş Durumu</th>
                                        <th>İlerleme Durumu</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <script>
                                        function SiparisDetayaGit(Id) {
                                            window.location.href = ""/Siparis/SiparisDetay?Id="" + Id;
                                        }
                                    </script>
");
#nullable restore
#line 51 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 2927, "\"", 2963, 3);
            WriteAttributeValue("", 2937, "SiparisDetayaGit(", 2937, 17, true);
#nullable restore
#line 53 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
WriteAttributeValue("", 2954, item.Id, 2954, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2962, ")", 2962, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <td class=\"py-1\">\r\n                                                ");
#nullable restore
#line 55 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                           Write(item.SiparisNumarasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td> ");
#nullable restore
#line 57 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                            Write(item.Kullanicilar.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                                                  Write(item.Kullanicilar.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 59 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                           Write(item.ToplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 61 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                           Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            <td>\r\n                                                <label class=\"badge badge-info\">");
#nullable restore
#line 64 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                                                           Write(item.OdemeDurum.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            </td>\r\n                                            <td>\r\n                                                <label class=\"badge badge-warning\">");
#nullable restore
#line 67 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                                                              Write(item.SiparisDurum.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            </td>\r\n                                            <td>\r\n                                                <div class=\"progress\">\r\n");
#nullable restore
#line 71 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                                      
                                                        var IlerlemeYuzde = 16.66 * item.SiparisDurumId;
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 4369, "\"", 4428, 3);
            WriteAttributeValue("", 4377, "width:", 4377, 6, true);
#nullable restore
#line 74 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
WriteAttributeValue(" ", 4383, IlerlemeYuzde.ToString().Replace(",","."), 4384, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4426, "%;", 4426, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 4429, "\"", 4487, 1);
#nullable restore
#line 74 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
WriteAttributeValue("", 4445, IlerlemeYuzde.ToString().Replace(",","."), 4445, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                                                </div>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Siparis\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <!-- partial:partials/_footer.html -->
            <footer class=""footer"">
                <div class=""container"">
                    <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
                        <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">Copyright © SRK YILMAZ İNŞAAT (Tüm Hakları Saklıdır) </span>
                    </div>
                    <div>
                    </div>
                </div>
            </footer>
            <!-- partial -->
        </div>
        <!-- main-panel ends -->
    </div>
    <!-- page-body-wrapper ends -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Siparis>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
