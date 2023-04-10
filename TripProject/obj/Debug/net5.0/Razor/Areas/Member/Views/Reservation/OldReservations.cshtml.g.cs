#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a4a6e4e89a6922e7c7ffc4a8240f456b079da5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_OldReservations), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/OldReservations.cshtml")]
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
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\_ViewImports.cshtml"
using TripProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\_ViewImports.cshtml"
using TripProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\_ViewImports.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a4a6e4e89a6922e7c7ffc4a8240f456b079da5", @"/Areas/Member/Views/Reservation/OldReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3129622749acc80ac61399629e5591957c10fb48", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Reservation_OldReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
  
    ViewData["Title"] = "OldReservations";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
   if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Geçmiş Rezervasyonunuz Bulunmamaktadır</h1>\r\n");
#nullable restore
#line 12 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-12"">
                <div class=""card mb-4"">
                    <div class=""card-header pb-0"">
                        <h6>Geçmiş Rezervasyonlarım</h6>
                    </div>
                    <div class=""card-body px-0 pt-0 pb-2"">
                        <div class=""table-responsive p-0"">
                            <table class=""table align-items-center mb-0"">
                                <thead>
                                    <tr>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Rezervasyon ID</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Şehir</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Açıklama</th>
                                        <th class=""text-uppercase text-secondary te");
            WriteLiteral(@"xt-xxs font-weight-bolder opacity-7 ps-2"">Kişi Sayısı</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Statü</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 34 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 37 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
                                           Write(item.ReservationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 38 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
                                           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 39 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 40 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
                                           Write(item.ReservationCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            <td class=\"align-middle text-sm-right text-sm\">\r\n                                                <span class=\"badge badge-sm bg-gradient-primary\">");
#nullable restore
#line 43 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
                                                                                            Write(item.ReservationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 56 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Areas\Member\Views\Reservation\OldReservations.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
