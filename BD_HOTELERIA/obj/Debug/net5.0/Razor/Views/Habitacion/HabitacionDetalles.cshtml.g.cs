#pragma checksum "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be973c77eff5b1b162102b745e50ec47b5cd161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Habitacion_HabitacionDetalles), @"mvc.1.0.view", @"/Views/Habitacion/HabitacionDetalles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be973c77eff5b1b162102b745e50ec47b5cd161", @"/Views/Habitacion/HabitacionDetalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0dfecaab73e93e225b337a8ff03c53c529dfba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Habitacion_HabitacionDetalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BD_HOTELERIA.Models.Habitacion>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HabitacionListado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HabitacionEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
  
    ViewData["Title"] = "HabitacionDetalles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Habitacion Detalles</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-4\">\r\n            Numero de Habitacion :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 16 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.NumeroHabitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Piso :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 22 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.Piso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Descripcion :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 28 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Precio de 8 Horas :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 34 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.Precio8Horas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Precio por Dia :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 40 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.PrecioDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Estado :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 46 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Eliminado :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 52 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.Eliminado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-4\">\r\n            Tipo de Habitacion :\r\n        </dt>\r\n        <dd class = \"col-sm-8\">\r\n            ");
#nullable restore
#line 58 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
       Write(Html.DisplayFor(model => model.IdTipoHabitacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-12\">\r\n            <div class=\"row\">\r\n                <div class=\"col-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be973c77eff5b1b162102b745e50ec47b5cd1619173", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be973c77eff5b1b162102b745e50ec47b5cd16110500", async() => {
                WriteLiteral("\r\n                        <strong>Editar</strong> \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\JOSE LUIS\Videos\c#_4ciclo\BD_HOTELERIA\BD_HOTELERIA\Views\Habitacion\HabitacionDetalles.cshtml"
                                                       WriteLiteral(Model.IdHabitacion);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BD_HOTELERIA.Models.Habitacion> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
