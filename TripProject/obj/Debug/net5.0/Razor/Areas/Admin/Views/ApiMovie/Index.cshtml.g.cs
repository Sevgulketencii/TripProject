#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b5062c4c0e5e9e3b63e65c41290c3c167a9bb25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiMovie_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiMovie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5062c4c0e5e9e3b63e65c41290c3c167a9bb25", @"/Areas/Admin/Views/ApiMovie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bb4ab0bef3885e5bc989501e83927cdea3c4dd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ApiMovie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieApiModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5 class=\"pb-1 mb-4\" style=\"margin-top:15px\">IMBD TOP 100 MOVIE</h5>\r\n<div class=\"row mb-5\">\r\n");
#nullable restore
#line 10 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-xl-4\">\r\n            <div class=\"card mb-3\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
                                      Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
                   Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p class=\"card-text\">\r\n                        <small class=\"text-muted\">");
#nullable restore
#line 20 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
                                             Write(item.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
                                                          Write(item.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </p>\r\n                </div>\r\n                <img class=\"card-img-bottom\"");
            BeginWriteAttribute("src", " src=\"", 773, "\"", 790, 1);
#nullable restore
#line 23 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 779, item.image, 779, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\ApiMovie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieApiModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
