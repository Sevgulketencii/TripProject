#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\Components\DestinationList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd17c1328f52047e533b11e78705bacc2e0ee0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DestinationList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DestinationList/Default.cshtml")]
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
#line 1 "C:\Users\keten\source\repos\TripProject\TripProject\Views\_ViewImports.cshtml"
using TripProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Views\_ViewImports.cshtml"
using TripProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\keten\source\repos\TripProject\TripProject\Views\_ViewImports.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd17c1328f52047e533b11e78705bacc2e0ee0b", @"/Views/Shared/Components/DestinationList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3129622749acc80ac61399629e5591957c10fb48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DestinationList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-12 mt-4"">
    <div class=""card mb-4"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-1"">Rotalarımız</h6>
            <p class=""text-sm"">Aktif Olan Rotalarımız</p>
        </div>
        <div class=""card-body p-3"">
            <div class=""row"">
              
");
#nullable restore
#line 12 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\Components\DestinationList\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-xl-3 col-md-6 mb-xl-0 mb-4 "" style=""margin-top:15px"">
                        <div class=""card card-blog card-plain"">
                            <div class=""position-relative"">
                                <a class=""d-block shadow-xl border-radius-xl"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 736, "\"", 758, 1);
#nullable restore
#line 18 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\Components\DestinationList\Default.cshtml"
WriteAttributeValue("", 742, item.RouteImage, 742, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""img-blur-shadow"" class=""img-fluid shadow border-radius-xl"" >
                                </a>
                            </div>
                            <div class=""card-body px-1 pb-0"">
                                <p class=""text-gradient text-dark mb-2 text-sm"">Project #2</p>
                                <a href=""javascript:;"">
                                    <h5>
                                        ");
#nullable restore
#line 25 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\Components\DestinationList\Default.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                </a>\r\n                                <p class=\"mb-4 text-sm\">\r\n                                    ");
#nullable restore
#line 29 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\Components\DestinationList\Default.cshtml"
                               Write(item.RouteDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <div class=""d-flex align-items-center justify-content-between"">
                                    <button type=""button"" class=""btn btn-outline-primary btn-sm mb-0"">View Project</button>
                                    <div class=""avatar-group mt-2"">
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Elena Morison"">
                                            <img alt=""Image placeholder"" src=""../assets/img/team-1.jpg"">
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Ryan Milly"">
                                            <img alt=""Image placeholder"" src=""../assets/img/team-2.jpg"">
                                        </a>
                                  ");
            WriteLiteral(@"      <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Nick Daniel"">
                                            <img alt=""Image placeholder"" src=""../assets/img/team-3.jpg"">
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Peterson"">
                                            <img alt=""Image placeholder"" src=""../assets/img/team-4.jpg"">
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 51 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\Components\DestinationList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
