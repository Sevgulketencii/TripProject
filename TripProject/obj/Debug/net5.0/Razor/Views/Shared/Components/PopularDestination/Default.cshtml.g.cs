#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb8a24af0cbe9130b59fa83d103ffaa4a294acd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PopularDestination_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PopularDestination/Default.cshtml")]
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
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\_ViewImports.cshtml"
using TripProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\_ViewImports.cshtml"
using TripProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\_ViewImports.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb8a24af0cbe9130b59fa83d103ffaa4a294acd", @"/Views/Shared/Components/PopularDestination/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3129622749acc80ac61399629e5591957c10fb48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PopularDestination_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">En Favori</h6>
            <h3 class=""hny-title"">Popüler Turlar</h3>
        </div>
        <div class=""row bottom-ab-grids"">
          
");
#nullable restore
#line 11 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                    <div class=""subject-card-header p-4"">
                        <a href=""#"" class=""card_title p-lg-4d-block"">
                            <div class=""row align-items-center"">
                                <div class=""col-sm-5 subject-img"">
                                    <img");
            BeginWriteAttribute("src", " src=", 764, "", 785, 1);
#nullable restore
#line 18 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
WriteAttributeValue("", 769, item.RouteImage, 769, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 803, "\"", 809, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\r\n                                    <h4>");
#nullable restore
#line 21 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 22 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
                                  Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"dst-btm\">\r\n                                        <h6");
            BeginWriteAttribute("class", " class=\"", 1156, "\"", 1164, 0);
            EndWriteAttribute();
            WriteLiteral("> Başlayan Fiyatlarla </h6>\r\n                                        <span>$ ");
#nullable restore
#line 25 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <p class=\"sub-para\">");
#nullable restore
#line 27 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
                                                   Write(item.RouteDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\PopularDestination\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591
