#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "97afbbe87eaddfe07877d7bc2e7878b6be1eccf2eb7038ea7d6b4a50f4a6e031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UILayout), @"mvc.1.0.view", @"/Views/Shared/_UILayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"97afbbe87eaddfe07877d7bc2e7878b6be1eccf2eb7038ea7d6b4a50f4a6e031", @"/Views/Shared/_UILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"86c8163fda925635cd17d8d2e76da7dd97c7d5893af5811275a93cf284c58d61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__UILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\n<html lang=\"zxx\">\n\n\n");
#nullable restore
#line 8 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97afbbe87eaddfe07877d7bc2e7878b6be1eccf2eb7038ea7d6b4a50f4a6e0314050", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 11 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_NavbarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 13 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 15 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 17 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
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
            WriteLiteral("\n\n</html>\n\n\n");
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
