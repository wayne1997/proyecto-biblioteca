#pragma checksum "/Users/eratostenes/Desktop/ProyectoIntegrador/Areas/Empleado/Views/Pais1/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e076fb26b606ee9358b01ddbbc38ddc1d2970025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Empleado_Views_Pais1_Details), @"mvc.1.0.view", @"/Areas/Empleado/Views/Pais1/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Empleado/Views/Pais1/Details.cshtml", typeof(AspNetCore.Areas_Empleado_Views_Pais1_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e076fb26b606ee9358b01ddbbc38ddc1d2970025", @"/Areas/Empleado/Views/Pais1/Details.cshtml")]
    public class Areas_Empleado_Views_Pais1_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoIntegrador.Models.Pais>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/eratostenes/Desktop/ProyectoIntegrador/Areas/Empleado/Views/Pais1/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Pais</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(259, 46, false);
#line 15 "/Users/eratostenes/Desktop/ProyectoIntegrador/Areas/Empleado/Views/Pais1/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombrePais));

#line default
#line hidden
            EndContext();
            BeginContext(305, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(369, 42, false);
#line 18 "/Users/eratostenes/Desktop/ProyectoIntegrador/Areas/Empleado/Views/Pais1/Details.cshtml"
       Write(Html.DisplayFor(model => model.NombrePais));

#line default
#line hidden
            EndContext();
            BeginContext(411, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 478, "\"", 506, 1);
#line 23 "/Users/eratostenes/Desktop/ProyectoIntegrador/Areas/Empleado/Views/Pais1/Details.cshtml"
WriteAttributeValue("", 493, Model.PaisID, 493, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(507, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoIntegrador.Models.Pais> Html { get; private set; }
    }
}
#pragma warning restore 1591
