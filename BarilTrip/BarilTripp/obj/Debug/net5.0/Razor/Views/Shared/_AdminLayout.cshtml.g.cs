#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "013a5b5a99e111373b7dc038f85518d5b15385a745d834b0e8c4bedc2a0b3358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\_ViewImports.cshtml"
using BarilTripp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\_ViewImports.cshtml"
using BarilTripp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"013a5b5a99e111373b7dc038f85518d5b15385a745d834b0e8c4bedc2a0b3358", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"86c8163fda925635cd17d8d2e76da7dd97c7d5893af5811275a93cf284c58d61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
#line 2 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<!-- beautify ignore:start -->\r\n<html lang=\"en\"\r\n      class=\"light-style layout-menu-fixed\"\r\n      dir=\"ltr\"\r\n      data-theme=\"theme-default\"\r\n      data-assets-path=\"../assets/\"\r\n      data-template=\"vertical-menu-template-free\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialHeader.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013a5b5a99e111373b7dc038f85518d5b15385a745d834b0e8c4bedc2a0b33584351", async() => {
                WriteLiteral("\r\n \r\n    <div class=\"layout-wrapper layout-content-navbar\">\r\n        <div class=\"layout-container\">\r\n            <aside id=\"layout-menu\" class=\"layout-menu menu-vertical menu bg-menu-theme\">               \r\n               \r\n                ");
#nullable restore
#line 23 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/PartialAppBrandDemo.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n               \r\n                <div class=\"menu-inner-shadow\"></div>\r\n               \r\n                ");
#nullable restore
#line 27 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/PartialSideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </aside>         \r\n            <div class=\"layout-page\">\r\n                \r\n                ");
#nullable restore
#line 31 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/PartialNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n           \r\n                <div class=\"content-wrapper\">\r\n                    \r\n                    <div class=\"container-xxl flex-grow-1 container-p-y\">\r\n                        \r\n                        ");
#nullable restore
#line 37 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    \r\n                    ");
#nullable restore
#line 40 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("/Views/Admin/PartialFooter.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    
                    <div class=""content-backdrop fade""></div>
                </div>               
            </div>          
        </div>       
        <div class=""layout-overlay layout-menu-toggle""></div>
    </div>  
    ");
#nullable restore
#line 48 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
