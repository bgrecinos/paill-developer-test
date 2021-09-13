#pragma checksum "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca945b6afef95300e047566c3ba9940134180fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Habilidades_Index), @"mvc.1.0.view", @"/Views/Habilidades/Index.cshtml")]
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
#line 1 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\_ViewImports.cshtml"
using PaillApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\_ViewImports.cshtml"
using PaillApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca945b6afef95300e047566c3ba9940134180fcc", @"/Views/Habilidades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef872654838f2565690afb57f10a26a5afaaff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Habilidades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PaillApp.Models.EmpleadoHabilidadViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
     if (TempData["succes"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 12 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
       Write(TempData["succes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
     if (TempData["warning"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 21 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
       Write(TempData["warning"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <h3>Listado de habilidades por Empleado</h3>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 36 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
             if (Model.Count() > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <table id=\"areas\" class=\"table table-striped table-bordered\" style=\"width:100%\">\r\n                    <thead>\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.IdHabilidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.IdEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                           Write(Html.DisplayNameFor(m => m.NombreHabilidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                               Write(item.IdHabilidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                               Write(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                               Write(item.NombreHabilidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 58 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No existen registros</p>\r\n");
#nullable restore
#line 62 "C:\Users\BRYAN\source\repos\paill-developer-test\PaillApp\Views\Habilidades\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            $(document).ready(function () {\r\n                $(\'#areas\').DataTable({\r\n                    responsive: true\r\n                });\r\n            });\r\n        </script>\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PaillApp.Models.EmpleadoHabilidadViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
