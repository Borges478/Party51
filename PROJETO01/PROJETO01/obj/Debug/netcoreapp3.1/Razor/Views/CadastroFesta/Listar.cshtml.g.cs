#pragma checksum "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd0d4b7a4ff060fabf514a1dbf6dbf7514ccdad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroFesta_Listar), @"mvc.1.0.view", @"/Views/CadastroFesta/Listar.cshtml")]
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
#line 1 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0d4b7a4ff060fabf514a1dbf6dbf7514ccdad3", @"/Views/CadastroFesta/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroFesta_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.CadastroFesta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />
<h3>
    CADASTRO DE FESTAS
    <a class=""btn btn-dark  float-right"" href=""/CadastroFesta/Adicionar"" style=""background-color:indigo"">
        + ADICIONAR
    </a>
</h3>

<table class=""table table-hover text-nowrap"">
    <thead>
        <tr>
            <th>FestaID</th>
            <th>Nome</th>
            <th>Endereço</th>
            <th>Bairro</th>
            <th>Cidade</th>
            <th>Estado</th>
            <th>Data e Hora</th>
            <th>Preço do ingresso</th>
            <th>Organizador</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.FestaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.DataFesta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.PrecoIngresso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
           Write(item.OrganizadorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1092, "\"", 1142, 2);
            WriteAttributeValue("", 1099, "/CadastroFesta/Editar?FestaID=", 1099, 30, true);
#nullable restore
#line 42 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
WriteAttributeValue("", 1129, item.FestaID, 1129, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                    Editar\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1245, "\"", 1296, 2);
            WriteAttributeValue("", 1252, "/CadastroFesta/Excluir?FestaID=", 1252, 31, true);
#nullable restore
#line 45 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
WriteAttributeValue("", 1283, item.FestaID, 1283, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                    Excluir\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\040847\Desktop\Nova pasta\Party51\PROJETO01\PROJETO01\Views\CadastroFesta\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.CadastroFesta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
