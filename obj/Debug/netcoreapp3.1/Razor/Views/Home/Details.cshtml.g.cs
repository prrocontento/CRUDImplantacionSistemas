#pragma checksum "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a29b5f8cc079e1e4f6b4b7c8f8760670e87e0a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\_ViewImports.cshtml"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\_ViewImports.cshtml"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a29b5f8cc079e1e4f6b4b7c8f8760670e87e0a37", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a15a183d38432e5d59901f4b5b9ca0de63cbe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Carreras>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-2\">Id</dt>\r\n            <dd class=\"col-10\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\Home\Details.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-2\">Titulo</dt>\r\n            <dd class=\"col-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\Home\Details.cshtml"
           Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-2\">Creditos</dt>\r\n            <dd class=\"col-10\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\Home\Details.cshtml"
           Write(Model.Creditos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-2\">Campus</dt>\r\n            <dd class=\"col-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Ernesto\source\repos\ProyectoFinal\ProyectoFinal\Views\Home\Details.cshtml"
           Write(Model.Campus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Carreras> Html { get; private set; }
    }
}
#pragma warning restore 1591