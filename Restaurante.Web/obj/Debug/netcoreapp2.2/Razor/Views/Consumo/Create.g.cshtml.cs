#pragma checksum "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17bdca92a1d5be860684944964852c6d08a27486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consumo_Create), @"mvc.1.0.view", @"/Views/Consumo/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consumo/Create.cshtml", typeof(AspNetCore.Views_Consumo_Create))]
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
#line 1 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\_ViewImports.cshtml"
using Restaurante.Web;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\_ViewImports.cshtml"
using Restaurante.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bdca92a1d5be860684944964852c6d08a27486", @"/Views/Consumo/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0597faed88f707bcd8802ae719d0c7ce62baa07c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consumo_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurante.Domain.Entities.Consumo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 42, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Consumo</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(121, 28, false);
#line 7 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(162, 33, false);
#line 9 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
   Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(199, 214, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Identificação\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(414, 90, false);
#line 16 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
           Write(Html.EditorFor(model => model.id, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(504, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(559, 44, false);
#line 17 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(603, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(651, 141, true);
            WriteLiteral("        <div class=\"editor-label\">\r\n                Restaurante\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(793, 99, false);
#line 25 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
           Write(Html.EditorFor(model => model.restaurante, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(892, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(947, 53, false);
#line 26 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.restaurante));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 30, true);
            WriteLiteral("</small>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1032, 206, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Valor\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1239, 93, false);
#line 34 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
           Write(Html.EditorFor(model => model.valor, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1387, 47, false);
#line 35 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1482, 205, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n            <div class=\"editor-label\">\r\n                Data\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(1688, 92, false);
#line 44 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
           Write(Html.EditorFor(model => model.data, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 54, true);
            WriteLiteral("\r\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1835, 46, false);
#line 45 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.data));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 46, true);
            WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1929, 156, true);
            WriteLiteral("        <div class=\"d-block text-center\">\r\n            <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Adicionar</button>\r\n\r\n            ");
            EndContext();
            BeginContext(2086, 93, false);
#line 52 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
       Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 54 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\Restaurante\Restaurante.Web\Views\Consumo\Create.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurante.Domain.Entities.Consumo> Html { get; private set; }
    }
}
#pragma warning restore 1591
