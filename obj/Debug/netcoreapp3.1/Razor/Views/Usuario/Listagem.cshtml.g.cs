#pragma checksum "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc78359b7a40e595d00d0effccbfe8ea1cf7018b"
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
#line 1 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc78359b7a40e595d00d0effccbfe8ea1cf7018b", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p class=\"text-danger\">");
#nullable restore
#line 1 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n    \r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
         foreach(Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                 if(u.Tipo == Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 22 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padr??o</td>\r\n");
#nullable restore
#line 26 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 637, "\"", 659, 2);
            WriteAttributeValue("", 644, "Edicao?id=", 644, 10, true);
#nullable restore
#line 28 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 654, u.Id, 654, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 720, 2);
            WriteAttributeValue("", 703, "Exclusao?id=", 703, 12, true);
#nullable restore
#line 29 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 715, u.Id, 715, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Yasmin\Desktop\tecnico_em_informatica\UC7\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"Cadastro\">Cadastrar novo usu??rio</a>");
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
