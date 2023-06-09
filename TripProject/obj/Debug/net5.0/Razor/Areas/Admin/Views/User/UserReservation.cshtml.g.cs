#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d3a9610d16f681fec99fb336d285cfc0cbd8e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UserReservation), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UserReservation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d3a9610d16f681fec99fb336d285cfc0cbd8e04", @"/Areas/Admin/Views/User/UserReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bb4ab0bef3885e5bc989501e83927cdea3c4dd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_UserReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
  
    ViewData["Title"] = "UserReservation";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h5 class=""card-header"">Kullanıcının Rezervasyonları</h5>
<div class=""table-responsive text-nowrap"">
    <table class=""table"">
        <thead class=""table-light"">
            <tr>
                <th>#</th>
                <th>Ad Soyad</th>
                <th>Rota</th>
                <th>Kişi Sayısı</th>
                <th>Tarih</th>
                <th>Detaylar</th>

            </tr>
        </thead>
        <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 23 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 26 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
                      sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 27 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
                                                                                 Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                    <td>#</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
                   Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
                   Write(item.ReservationCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
                    Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   \r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1133, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Tur Geçmişi</a> </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\User\UserReservation.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
