#pragma checksum "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be63f75a4ccc2b7b72dc83ffb5144ec49d9f069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\xampp\htdocs\cicalacos\Views\_ViewImports.cshtml"
using uc4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\cicalacos\Views\_ViewImports.cshtml"
using uc4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be63f75a4ccc2b7b72dc83ffb5144ec49d9f069", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d43fcf5ef155fc3c7376b1b39dd773d26f1735", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pedidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Pedidos";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
 if (ViewBag.Mensagem == "Registro deletado com sucesso" && ViewBag.Mensagem != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        Pedido deletado com sucesso!\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">Nome</th>
      <th scope=""col"">Item Pedido</th>
      <th scope=""col"">Endereço</th>
      <th scope=""col"">Valor</th>
      <th scope=""col"">Forma de Pagamento</th>
    </tr>
  </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
         foreach (Pedidos u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
               Write(u.ItemPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
               Write(u.Endereço);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
               Write(u.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
               Write(u.FormaPag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 891, "\"", 922, 2);
            WriteAttributeValue("", 898, "/Usuario/Editar?id=", 898, 19, true);
#nullable restore
#line 34 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 917, u.Id, 917, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <button type=\"button\" class=\"btn btn-primary\">Editar</button></a>\r\n                  </td>\r\n                <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1078, "\"", 1110, 2);
            WriteAttributeValue("", 1085, "/Usuario/Deletar?id=", 1085, 20, true);
#nullable restore
#line 38 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1105, u.Id, 1105, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <button type=\"button\" class=\"btn btn-danger\">Apagar</button>\r\n                  </a>\r\n                  </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\xampp\htdocs\cicalacos\Views\Usuario\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pedidos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
