#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\TripProject\TripProject\Views\Shared\Components\CardStatistic2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5de6de20c51080230e89de430539da9ffb7a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CardStatistic2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CardStatistic2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5de6de20c51080230e89de430539da9ffb7a31", @"/Views/Shared/Components/CardStatistic2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3129622749acc80ac61399629e5591957c10fb48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CardStatistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-md-8 col-lg-4 order-3 order-md-2"">
    <div class=""row"">
        <div class=""col-6 mb-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title d-flex align-items-start justify-content-between"">
                        <div class=""avatar flex-shrink-0"">
                            <img src=""/sneat-1.0.0/assets/img/icons/unicons/paypal.png"" alt=""Credit Card"" class=""rounded"" />
                        </div>
                        <div class=""dropdown"">
                            <button class=""btn p-0""
                                    type=""button""
                                    id=""cardOpt4""
                                    data-bs-toggle=""dropdown""
                                    aria-haspopup=""true""
                                    aria-expanded=""false"">
                                <i class=""bx bx-dots-vertical-rounded""></i>
                            </button>
                      ");
            WriteLiteral(@"      
                        </div>
                    </div>
                    <span class=""d-block mb-1"">Ağustos</span>
                    <h3 class=""card-title text-nowrap mb-2"">2,456 ₺</h3>
                    <small class=""text-danger fw-semibold""><i class=""bx bx-down-arrow-alt""></i> -14.82%</small>
                </div>
            </div>
        </div>
        <div class=""col-6 mb-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title d-flex align-items-start justify-content-between"">
                        <div class=""avatar flex-shrink-0"">
                            <img src=""/sneat-1.0.0/assets/img/icons/unicons/cc-primary.png"" alt=""Credit Card"" class=""rounded"" />
                        </div>
                        <div class=""dropdown"">
                            <button class=""btn p-0""
                                    type=""button""
                                    id=""cardOpt1""
                   ");
            WriteLiteral(@"                 data-bs-toggle=""dropdown""
                                    aria-haspopup=""true""
                                    aria-expanded=""false"">
                                <i class=""bx bx-dots-vertical-rounded""></i>
                            </button>
                            
                        </div>
                    </div>
                    <span class=""fw-semibold d-block mb-1"">Eylül</span>
                    <h3 class=""card-title mb-2"">14,857 ₺</h3>
                    <small class=""text-success fw-semibold""><i class=""bx bx-up-arrow-alt""></i> +28.14%</small>
                </div>
            </div>
        </div>
        <!-- </div>
        <div class=""row""> -->
        <div class=""col-12 mb-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""d-flex justify-content-between flex-sm-row flex-column gap-3"">
                        <div class=""d-flex flex-sm-column flex-row align-items-start justify");
            WriteLiteral(@"-content-between"">
                            <div class=""card-title"">
                                <h5 class=""text-nowrap mb-2"">Profil Raporu</h5>
                                <span class=""badge bg-label-warning rounded-pill"">2023 Toplam Kazanç</span>
                            </div>
                            <div class=""mt-sm-auto"">
                                <small class=""text-success text-nowrap fw-semibold""><i class=""bx bx-chevron-up""></i> 68.2%</small>
                                <h3 class=""mb-0"">84,686 ₺</h3>
                            </div>
                        </div>
                        <div id=""profileReportChart""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
