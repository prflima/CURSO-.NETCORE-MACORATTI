#pragma checksum "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\Clientes\Detalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b49163003ea2c1fbc1f017b2640e9cd6229cb96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Detalhe), @"mvc.1.0.view", @"/Views/Clientes/Detalhe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Detalhe.cshtml", typeof(AspNetCore.Views_Clientes_Detalhe))]
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
#line 1 "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\_ViewImports.cshtml"
using AspNetCoreMVC;

#line default
#line hidden
#line 2 "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\_ViewImports.cshtml"
using AspNetCoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b49163003ea2c1fbc1f017b2640e9cd6229cb96", @"/Views/Clientes/Detalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314f99dc36cfdcfa0f2f030bcf7b45c920ad4977", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Detalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreMVC.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\Clientes\Detalhe.cshtml"
  
    ViewData["Title"] = "Detalhe";

#line default
#line hidden
            BeginContext(83, 48, true);
            WriteLiteral("\r\n<h2>Detalhe</h2>\r\n\r\n<h3>Cliente</h3>\r\n<hr />\r\n");
            EndContext();
            BeginContext(132, 15, false);
#line 11 "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\Clientes\Detalhe.cshtml"
Write(Model.ClienteId);

#line default
#line hidden
            EndContext();
            BeginContext(147, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(156, 10, false);
#line 12 "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\Clientes\Detalhe.cshtml"
Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(166, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(176, 11, false);
#line 13 "C:\Users\PauloLima\Desktop\Módulos Macoratti\Módulo 2 - MVC Parte 1\AspNetCoreMVC\AspNetCoreMVC\Views\Clientes\Detalhe.cshtml"
Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(187, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreMVC.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
