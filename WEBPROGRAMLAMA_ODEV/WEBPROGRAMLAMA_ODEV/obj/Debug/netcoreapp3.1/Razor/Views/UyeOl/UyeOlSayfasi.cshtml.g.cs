#pragma checksum "C:\Users\mRyellow\Desktop\HERŞEYİYLE SON\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\UyeOl\UyeOlSayfasi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a74f7da0a0bdafe1bac4b4a0bcb3b24adf37ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UyeOl_UyeOlSayfasi), @"mvc.1.0.view", @"/Views/UyeOl/UyeOlSayfasi.cshtml")]
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
#line 1 "C:\Users\mRyellow\Desktop\HERŞEYİYLE SON\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\_ViewImports.cshtml"
using WEBPROGRAMLAMA_ODEV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mRyellow\Desktop\HERŞEYİYLE SON\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\_ViewImports.cshtml"
using WEBPROGRAMLAMA_ODEV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a74f7da0a0bdafe1bac4b4a0bcb3b24adf37ae", @"/Views/UyeOl/UyeOlSayfasi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acaa571bdf78b7e82ad4ff373f6103a04689cbc8", @"/Views/_ViewImports.cshtml")]
    public class Views_UyeOl_UyeOlSayfasi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\mRyellow\Desktop\HERŞEYİYLE SON\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\UyeOl\UyeOlSayfasi.cshtml"
  
    ViewData["Title"] = "Üye Ol";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--
<style>
    .deneme_uyeol {
        width: 1200px;
        height: 300px;
        margin: 0;
        padding: 0;
        background-image: url('../wwwroot/img/ÜyeOlmaEkranı/sopranos.jpg');
    }
</style> -->

<section class=""normal-breadcrumb set-bg"" data-setbg=""/img/ÜyeOlmaEkranı/sopranos.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""normal__breadcrumb__text"">
                    <h2>ÜYE OL</h2>
                    <p>Dizile.com Üye Olma sayfası</p>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""signup spad"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-6"">
                <div class=""login__form"">

                    <h3>ÜYE OL</h3>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a74f7da0a0bdafe1bac4b4a0bcb3b24adf37ae4826", async() => {
                WriteLiteral(@"
                        <div class=""input__item"">
                            <input type=""text"" placeholder=""Kullanıcı Adı"">
                            <span class=""icon_profile""></span>
                        </div>
                        <div class=""input__item"">
                            <input type=""text"" placeholder=""Parola"">
                            <span class=""icon_lock""></span>
                        </div>
                        <button type=""submit"" class=""site-btn"">Üye Ol</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    <h5>Zaten bir hesabın var mı? <a href=""#"">Giriş Yap!</a></h5>
                </div>
            </div>

            <div class=""col-lg-6"">

                <div class=""anime__details__text"">
                    <p>
                        <span style=""color:white"">
                            &nbsp;&nbsp;&nbsp;&nbsp;Üye olun ve Dizile.com da yerinizi alın.Üyelere özel yorum yapma , beğenme gibi özelliklere erişin.
                            Yorum yaparak diğer kullanıcılarla iletişime geçin ve fikir alış-verişinde bulunun.
                        </span>
                    </p>
                </div>

            </div>

        </div>
    </div>
</section>");
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
