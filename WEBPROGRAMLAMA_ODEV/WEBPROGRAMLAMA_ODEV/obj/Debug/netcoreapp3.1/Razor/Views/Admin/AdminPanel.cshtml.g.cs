#pragma checksum "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\AdminPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51617619f403e29977d57780938b6f7479e5f55c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminPanel), @"mvc.1.0.view", @"/Views/Admin/AdminPanel.cshtml")]
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
#line 1 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\_ViewImports.cshtml"
using WEBPROGRAMLAMA_ODEV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\_ViewImports.cshtml"
using WEBPROGRAMLAMA_ODEV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51617619f403e29977d57780938b6f7479e5f55c", @"/Views/Admin/AdminPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acaa571bdf78b7e82ad4ff373f6103a04689cbc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\AdminPanel.cshtml"
  
    ViewData["Title"] = "Admin Giriş";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""normal-breadcrumb set-bg"" data-setbg=""/img/GirişYapEkranı/sonsofanarchy.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""normal__breadcrumb__text"">
                    <h2>GİRİŞ YAP</h2>
                    <p>Dizile.com Giriş Yapma Sayfası</p>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""login spad"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-6"">
                <div class=""login__form"">
                    <h3>GİRİŞ YAP</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51617619f403e29977d57780938b6f7479e5f55c4719", async() => {
                WriteLiteral("\r\n\r\n                        <div class=\"input__item\">\r\n                            <input type=\"text\" placeholder=\"Kullanıcı Adı\" class=\"name\" name=\"KullaniciAdi\"");
                BeginWriteAttribute("required", " required=\"", 907, "\"", 918, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span class=\"icon_profile\"></span>\r\n                        </div>\r\n\r\n                        <div class=\"input__item\">\r\n                            <input type=\"password\" placeholder=\"Parola\" class=\"password\" name=\"Sifre\"");
                BeginWriteAttribute("required", " required=\"", 1172, "\"", 1183, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span class=\"icon_lock\"></span>\r\n                        </div>\r\n\r\n                        <button type=\"submit\" class=\"site-btn\">Giriş Yap</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
