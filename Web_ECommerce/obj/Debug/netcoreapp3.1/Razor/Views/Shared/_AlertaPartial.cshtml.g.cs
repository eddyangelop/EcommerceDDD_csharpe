#pragma checksum "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252023619b5f67a3a531a2c557130921a2c0b414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AlertaPartial), @"mvc.1.0.view", @"/Views/Shared/_AlertaPartial.cshtml")]
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
#line 1 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252023619b5f67a3a531a2c557130921a2c0b414", @"/Views/Shared/_AlertaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684f3d0ac3ee691da11a2a86cebab3ec537bc857", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AlertaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
  
    bool sucesso = false;
    bool alerta = false;
    bool erro = false;
    string mensagem = string.Empty;

    sucesso = ViewBag.Sucesso != null ? ViewBag.sucesso : false;
    alerta = ViewBag.Alerta != null ? ViewBag.Alerta : false;
    erro = ViewBag.Erro != null ? ViewBag.Erro : false;

    mensagem = ViewBag.Mensagem != null ? ViewBag.Mensagem : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
 if (sucesso)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 18 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
           Write(mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
 if (alerta)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 26 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
           Write(mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
 if (erro)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 34 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
           Write(mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\edson\Downloads\Documents\Dotnet\EcommerceDDD_csharpe\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"AlertaJavaScript\">\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
