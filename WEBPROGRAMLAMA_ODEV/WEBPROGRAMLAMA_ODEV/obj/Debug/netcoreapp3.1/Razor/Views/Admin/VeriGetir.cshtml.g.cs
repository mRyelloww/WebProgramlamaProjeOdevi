#pragma checksum "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77758fa0a1da925f432e22e0ab85bfc04bf458f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_VeriGetir), @"mvc.1.0.view", @"/Views/Admin/VeriGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77758fa0a1da925f432e22e0ab85bfc04bf458f5", @"/Views/Admin/VeriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acaa571bdf78b7e82ad4ff373f6103a04689cbc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_VeriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBPROGRAMLAMA_ODEV.Models.Diziler>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
  
    ViewData["Title"] = "Tablodan Veri Getirme Paneli";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<link rel=\"stylesheet\" href=\"https://www.w3schools.com/w3css/4/w3.css\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77758fa0a1da925f432e22e0ab85bfc04bf458f54523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<!--başlangıç formu belirledik. içinde BirimControllerda bulunuacak ve\r\n    Post metot kullanıldığında çalışacak yani buton falan basıldığında-->\r\n");
#nullable restore
#line 12 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
 using (Html.BeginForm("DiziGuncelle", "Admin", FormMethod.Post))
{
    /*bu form DiziGüncelle actionResultı çalıştıracak ve içinde Birim isimli controller olacak
    post olduğunda çalışacak*/
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
Write(Html.LabelFor(x => x.DiziID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
Write(Html.TextBoxFor(x => x.DiziID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
                                                                    /*form-control kısmı veri giriş yeri daha güzel gözüksün diye*/

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
Write(Html.LabelFor(x => x.DiziAd));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
Write(Html.TextBoxFor(x => x.DiziAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-def\" style=\"background-color:#00ff21\">Veri Güncelle</button>\r\n");
#nullable restore
#line 25 "D:\ilker\Masaüstü\PROJE SAVE\SAVE YARIN COMMİTLENECEK\WebProgramlamaProjeOdevi\WEBPROGRAMLAMA_ODEV\WEBPROGRAMLAMA_ODEV\Views\Admin\VeriGetir.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBPROGRAMLAMA_ODEV.Models.Diziler> Html { get; private set; }
    }
}
#pragma warning restore 1591