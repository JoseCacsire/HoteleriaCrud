#pragma checksum "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb21bed780c49f21383e5d1dbe84c8a2daa49370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultas_reservaciones_caras), @"mvc.1.0.view", @"/Views/Consultas/reservaciones_caras.cshtml")]
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
#line 1 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\_ViewImports.cshtml"
using BD_HOTELERIA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\_ViewImports.cshtml"
using BD_HOTELERIA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb21bed780c49f21383e5d1dbe84c8a2daa49370", @"/Views/Consultas/reservaciones_caras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0dfecaab73e93e225b337a8ff03c53c529dfba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Consultas_reservaciones_caras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BD_HOTELERIA.Models.reservaciones_caras>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
  
    ViewData["Title"] = "reservaciones_caras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"mt-5\">RESERVACIONES CARAS</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row py-3 text-left"">
        <div class=""col-md-3 d-flex align-items-center justify-content-start"">
            Seleccione una Categoria : 
        </div>
        <div class=""col-md-2 d-flex align-items-center justify-content-center"">
            ");
#nullable restore
#line 16 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
       Write(Html.DropDownList("idTipoHabitacion",(SelectList)ViewBag.LISTA_TIPOHABITACIONES, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-md-2 d-flex align-items-center justify-content-start"">
            Precio mayor a : 
        </div>
        <div class=""col-md-2 d-flex align-items-center justify-content-center"">
            <input type=""number"" name=""precio"" class=""form-control"">  
        </div>
        <div class=""col-md-3 d-flex align-items-center justify-content-end"">
            <button type=""submit"" class=""btn btn-primary"">
                Consultar
            </button>
        </div>
    </div>
");
#nullable restore
#line 30 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead class=""bg-secondary"">
        <style>th{color:white}</style>
        <tr>
            <th>
                ID
            </th>
            <th>
                ENTRADA
            </th>
            <th>
                SALIDA
            </th>
            <th>
                PRECIO
            </th>
            <th>
                N° HABITACION
            </th>
            <th>
                CLIENTE
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 56 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
           Write(Html.DisplayFor(modelItem => item.idReservacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
           Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
           Write(Html.DisplayFor(modelItem => item.numeroHabitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 77 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"alert alert-warning\">\r\n    Cantidad de Registros : ");
#nullable restore
#line 82 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Consultas\reservaciones_caras.cshtml"
                       Write(ViewBag.TOTAL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BD_HOTELERIA.Models.reservaciones_caras>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
