#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3fedbc3f3a24244e3d954fc93de80b5599204da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationCQRS_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
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
#line 1 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\_ViewImports.cshtml"
using TripProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\_ViewImports.cshtml"
using TripProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\_ViewImports.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\_ViewImports.cshtml"
using TripProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\_ViewImports.cshtml"
using TripProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3fedbc3f3a24244e3d954fc93de80b5599204da", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bb4ab0bef3885e5bc989501e83927cdea3c4dd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DestinationCQRS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllDestinationQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""margin-top:15px"">CQRS TURLAR TABLOSU</h1>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Şehir Adı</th>
            <th>Gün - Gece</th>
            <th>Kapasite</th>
            <th>Ücret</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
               Write(item.destinationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
               Write(item.destinationDayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
               Write(item.destinationCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
               Write(item.destinationPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 833, "\"", 879, 2);
            WriteAttributeValue("", 840, "/Admin/DestinationCQRS/GetById/", 840, 31, true);
#nullable restore
#line 31 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 871, item.ID, 871, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\r\n                <td><a href=\"#\"class=\"btn btn-danger\">Sil</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"#\" class=\"btn btn-success\">Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllDestinationQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
