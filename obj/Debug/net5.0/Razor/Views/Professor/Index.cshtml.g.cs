#pragma checksum "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c656e399524a98df06d564bb60f98b6a66ea78b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
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
#line 1 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\_ViewImports.cshtml"
using MVCRazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\_ViewImports.cshtml"
using MVCRazorCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c656e399524a98df06d564bb60f98b6a66ea78b", @"/Views/Professor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2c8090e596b78848a54e9bdc050b067fa383148", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
  
    var listaDeProfessores = ViewBag.ListaDeProfessores;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Aqui vamos criar nossa página de listagem de Professores</h1>

<table class=""table table-dark table-sm"">
    <thead>
        </tr>
    <th>ID</th>
    <th>Nome</th>
    <th>Email</th>
    <th>Endereço</th>
    <th>Telefone</th>
    <th>Cargo</th>
    <th>Ação</th>
    <tr>

        </thead>
");
#nullable restore
#line 19 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
         foreach (var item in listaDeProfessores)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
           Write(item.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 660, "\"", 709, 2);
            WriteAttributeValue("", 667, "https://localhost:44366/Professor/", 667, 34, true);
#nullable restore
#line 28 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
WriteAttributeValue("", 701, item.Id, 701, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-danger\">Excluir</button></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 796, "\"", 852, 2);
            WriteAttributeValue("", 803, "https://localhost:44366/Professor/Editar/", 803, 41, true);
#nullable restore
#line 29 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
WriteAttributeValue("", 844, item.Id, 844, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-light\">Editar</button></a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\dev\Desktop\Laura\MVCRazorCRUD\Views\Professor\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
