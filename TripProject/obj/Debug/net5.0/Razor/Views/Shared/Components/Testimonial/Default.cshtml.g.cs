#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2f66d0eff6fed23e80db46c070ef0ac2c1082c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2f66d0eff6fed23e80db46c070ef0ac2c1082c", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3129622749acc80ac61399629e5591957c10fb48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-clients"" id=""clients"">
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Müşterilerimizin</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">Hakkımızdaki Yorumları</h3>
            </div>
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 12 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\Testimonial\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""testimonial-content"">
                                <div class=""testimonial"">
                                    <blockquote>
                                        <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                        ");
#nullable restore
#line 19 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\Testimonial\Default.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </blockquote>\r\n                                    <div class=\"testi-des\">\r\n                                        <div class=\"test-img\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=", 1187, "", 1207, 1);
#nullable restore
#line 23 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\Testimonial\Default.cshtml"
WriteAttributeValue("", 1192, item.ClientImg, 1192, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\r\n                                        </div>\r\n                                        <div class=\"peopl align-self\">\r\n                                            <h3>");
#nullable restore
#line 26 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\Testimonial\Default.cshtml"
                                           Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                            <p class=""indentity"">-</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 33 "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\Testimonial\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
