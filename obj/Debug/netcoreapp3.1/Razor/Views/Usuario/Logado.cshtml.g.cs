#pragma checksum "C:\Users\Lucas\OneDrive\Documentos\uc4\Views\Usuario\Logado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af8c0fa334815839601a4128e4fb79ff4292b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Logado), @"mvc.1.0.view", @"/Views/Usuario/Logado.cshtml")]
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
#line 1 "C:\Users\Lucas\OneDrive\Documentos\uc4\Views\_ViewImports.cshtml"
using uc4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\OneDrive\Documentos\uc4\Views\_ViewImports.cshtml"
using uc4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af8c0fa334815839601a4128e4fb79ff4292b53", @"/Views/Usuario/Logado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d43fcf5ef155fc3c7376b1b39dd773d26f1735", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Logado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lucas\OneDrive\Documentos\uc4\Views\Usuario\Logado.cshtml"
  
    ViewData["Title"] = "Logado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"list-group\">\r\n  <a href=\"Pedidos\" class=\"list-group-item list-group-item-action active\" aria-current=\"true\">\r\n    Cadastrar Pedidos\r\n  </a>\r\n  <a href=\"Listagem\" class=\"list-group-item list-group-item-action\">Ver Pedidos</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
