#pragma checksum "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7d0331f0f01361f0d879c30885fae304d0708a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategoriler_KategoriDetay), @"mvc.1.0.view", @"/Views/Kategoriler/KategoriDetay.cshtml")]
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
#line 2 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
using EPazar.Entity.SanalEntity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7d0331f0f01361f0d879c30885fae304d0708a", @"/Views/Kategoriler/KategoriDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389de6e98a8cf3b27c3eae541a0062c637640677", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kategoriler_KategoriDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PanelKategorilerEntityleri>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
  
    var Kategori = Model.Kategori;
    var AnaKategoriler = Model.AnaKategoriler;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid page-body-wrapper"">
    <div class=""main-panel"">
        <div class=""content-wrapper pb-0"">
            <div class=""page-header flex-wrap"">
                <div class=""header-left"">

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
                        <h3>AnaKategori Bilgileri</h3>
                        <div class=""card-body row"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b7d0331f0f01361f0d879c30885fae304d0708a5543", async() => {
                WriteLiteral("\r\n                                <select type=\"text\" name=\"AnaKategoriId\" class=\"btn btn-outline-secondary mb-2 mb-md-0\">\r\n");
#nullable restore
#line 34 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                     foreach (var item in AnaKategoriler)
                                    {
                                        if (item.Id == Kategori.AnaKategoriId)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b7d0331f0f01361f0d879c30885fae304d0708a6427", async() => {
#nullable restore
#line 38 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                                                         Write(item.Ad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b7d0331f0f01361f0d879c30885fae304d0708a9098", async() => {
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                                                Write(item.Ad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                                <div class=""col-12 row mt-4"">
                                    <div class=""col-4"" style=""font-weight: bold;"">
                                        Sıra
                                    </div>
                                    <div class=""col-8"">
                                        <input class=""form-control"" type=""number"" name=""Sira""");
                BeginWriteAttribute("value", " value=\"", 2211, "\"", 2233, 1);
#nullable restore
#line 51 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
WriteAttributeValue("", 2219, Kategori.Sira, 2219, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    </div>\r\n                                </div>\r\n                                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2385, "\"", 2405, 1);
#nullable restore
#line 54 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
WriteAttributeValue("", 2393, Kategori.Id, 2393, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <div class=""col-12 row mt-4"">
                                    <div class=""col-4"" style=""font-weight: bold;"">
                                        Ad
                                    </div>
                                    <div class=""col-8"">
                                        <input class=""form-control"" type=""text"" name=""Ad""");
                BeginWriteAttribute("value", " value=\"", 2792, "\"", 2812, 1);
#nullable restore
#line 60 "C:\Users\eaydin\Documents\GitHub\EPazar\EPazar\BigtarzPanel\Views\Kategoriler\KategoriDetay.cshtml"
WriteAttributeValue("", 2800, Kategori.Ad, 2800, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>

                                <div class=""col-12 row mt-4"">
                                    <div class=""col-4"" style=""font-weight: bold;"">
                                    </div>
                                    <div class=""col-8"">
                                        <button class=""btn btn-primary"">Kaydet</button>
                                    </div>
                                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PanelKategorilerEntityleri> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591