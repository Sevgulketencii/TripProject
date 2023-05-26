#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a147b98639aa7df95b7e2734f70430fa606ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a147b98639aa7df95b7e2734f70430fa606ba8", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bb4ab0bef3885e5bc989501e83927cdea3c4dd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<BR />\r\n<h3 class=\"mt-2 text-muted\">Rehber Listesi</h3>\r\n\r\n<div class=\"row mb-5\">\r\n");
#nullable restore
#line 12 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 col-lg-4\">\r\n            <div class=\"card\" style=\"margin-top:20px\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 369, "\"", 391, 1);
#nullable restore
#line 15 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 375, item.GuideImage, 375, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"340\" alt=\"Card image cap\" />\r\n                <div class=\"card-body\" style=\"margin:auto\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
                                      Write(item.GuideName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 18 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
                       if (item.GuideStatus == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button href=\"#\" style=\"margin-left:50px\" class=\"btn btn-success btn-sm\">AKTİF</button>\r\n");
#nullable restore
#line 21 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button href=\"#\" style=\"margin-left:50px\" class=\"btn btn-danger btn-sm\">PASİF</button>\r\n");
#nullable restore
#line 25 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\">");
#nullable restore
#line 31 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
                                           Write(item.GuideDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                </ul>\r\n                <div class=\"card-body\" style=\"margin:auto\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1333, 2);
            WriteAttributeValue("", 1295, "/Admin/Guide/ActiveGuide/", 1295, 25, true);
#nullable restore
#line 35 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1320, item.GuideID, 1320, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary \">Aktif Yap</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1397, "\"", 1443, 2);
            WriteAttributeValue("", 1404, "/Admin/Guide/PassiveGuide/", 1404, 26, true);
#nullable restore
#line 36 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1430, item.GuideID, 1430, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning \">Pasif Yap</a>\r\n                </div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1527, "\"", 1570, 2);
            WriteAttributeValue("", 1534, "/Admin/Guide/GuideEdit/", 1534, 23, true);
#nullable restore
#line 38 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1557, item.GuideID, 1557, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary btn-lg\">Düzenle</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\Guide\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Admin/Guide/GuideAdd\" class=\"btn btn-success btn-lg\" style=\"margin-top:20px\">Rehber Ekle</a>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
