#pragma checksum "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e74a08d2384c1f15a14eba34a25db187652900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MemberLayout), @"mvc.1.0.view", @"/Views/Shared/_MemberLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e74a08d2384c1f15a14eba34a25db187652900", @"/Views/Shared/_MemberLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3129622749acc80ac61399629e5591957c10fb48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MemberLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("g-sidenav-show  bg-gray-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
Write(await Html.PartialAsync("/Views/MemberLayoutPartial/MemberHead.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e74a08d2384c1f15a14eba34a25db1876529004232", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
Write(await Html.PartialAsync("/Views/MemberLayoutPartial/MemberNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <main class=\"main-content position-relative max-height-vh-100 h-100 mt-1 border-radius-lg \">\r\n        <!-- Navbar -->\r\n        ");
#nullable restore
#line 16 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
   Write(await Html.PartialAsync("/Views/MemberLayoutPartial/MemberNavbar2.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- End Navbar -->\r\n        <div class=\"container-fluid py-4\">\r\n\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 23 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            ");
#nullable restore
#line 25 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
       Write(await Html.PartialAsync("/Views/MemberLayoutPartial/MemberFooter.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </main>\r\n    ");
#nullable restore
#line 29 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
Write(await Html.PartialAsync("/Views/MemberLayoutPartial/MemberRightBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!--   Core JS Files   -->\r\n    ");
#nullable restore
#line 32 "C:\Users\keten\source\repos\TripProject\TripProject\Views\Shared\_MemberLayout.cshtml"
Write(await Html.PartialAsync("/Views/MemberLayoutPartial/MemberScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
