#pragma checksum "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86bbe9bd7d07676ca6e56c01355f93e72cd58f79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organizador_Listar), @"mvc.1.0.view", @"/Views/Organizador/Listar.cshtml")]
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
#line 1 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86bbe9bd7d07676ca6e56c01355f93e72cd58f79", @"/Views/Organizador/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Organizador_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.Organizador>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<br />
<br />
<br />

<div class=""container-fluid bg-light"" style=""border:solid"">
<br />
<h3>
    CADASTRO DE ORGANIZADORES
    <br />
    <a class=""btn btn-dark  float-right"" href=""/Organizador/Adicionar"" style=""background-color:indigo"">
        + ADICIONAR
    
   </a>
    <br />
</h3>
<br />
<table class=""table table-hover "">
    <thead>
        <tr>
            <th>OrganizadorID</th>
            <th>Nome</th>
            <th>CPF</th>
            <th>Telefone</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
               Write(item.OrganizadorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
               Write(item.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
               Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 944, 2);
            WriteAttributeValue("", 891, "/Organizador/Editar?OrganizadorID=", 891, 34, true);
#nullable restore
#line 39 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
WriteAttributeValue("", 925, item.OrganizadorID, 925, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-dark\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1117, 2);
            WriteAttributeValue("", 1063, "/Organizador/Excluir?OrganizadorID=", 1063, 35, true);
#nullable restore
#line 42 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
WriteAttributeValue("", 1098, item.OrganizadorID, 1098, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\gabri\Documents\Party51\Party51\PROJETO01\PROJETO01\Views\Organizador\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.Organizador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
