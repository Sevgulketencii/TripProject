#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874601387b422aa8b41e1bf04b16021a5d17db0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DashBoard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874601387b422aa8b41e1bf04b16021a5d17db0a", @"/Areas/Admin/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc002863238eeec658f036c967cc2ee066f73cbb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-xxl flex-grow-1 container-p-y\">\r\n\r\n    <div class=\"row\">\r\n\r\n       ");
#nullable restore
#line 13 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
  Write(await Component.InvokeAsync("DashBoardBanner"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n       \r\n       ");
#nullable restore
#line 15 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
  Write(await Component.InvokeAsync("CardStatistic1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n       \r\n       ");
#nullable restore
#line 17 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
  Write(await Component.InvokeAsync("TotalRevenue"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n       ");
#nullable restore
#line 19 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
  Write(await Component.InvokeAsync("CardStatistic2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n       \r\n        ");
#nullable restore
#line 25 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("DestinationStatistic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 27 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("DestinationStatistic2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 29 "C:\Users\keten\source\repos\TripProject\TripProject\Areas\Admin\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("DashBoardGuideList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
