#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\Shared\Components\_SubAbout\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d2916f888b6dac501d8f6badcf06fab6ea44b418da5e758dd4c0bf7aab83c4a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__SubAbout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_SubAbout/Default.cshtml")]
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
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\_ViewImports.cshtml"
using BarilTripp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\_ViewImports.cshtml"
using BarilTripp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\Shared\Components\_SubAbout\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d2916f888b6dac501d8f6badcf06fab6ea44b418da5e758dd4c0bf7aab83c4a2", @"/Views/Shared/Components/_SubAbout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"86c8163fda925635cd17d8d2e76da7dd97c7d5893af5811275a93cf284c58d61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__SubAbout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubAbout>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""w3l-bottom py-5"">
    <div class=""container py-md-4 py-3 text-center"">
        <div class=""row my-lg-4 mt-4"">
            <div class=""col-lg-9 col-md-10 ml-auto"">
                <div class=""bottom-info ml-auto"">
                    <div class=""header-section text-left"">
");
#nullable restore
#line 9 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\Shared\Components\_SubAbout\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3 class=\"hny-title two\">");
#nullable restore
#line 11 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\Shared\Components\_SubAbout\Default.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p class=\"mt-3 pr-lg-5\">\n                                ");
#nullable restore
#line 13 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\Shared\Components\_SubAbout\Default.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n");
#nullable restore
#line 15 "C:\Users\brsha\OneDrive\Masaüstü\BarilTripp\BarilTripp\Views\Shared\Components\_SubAbout\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"about.html\" class=\"btn btn-style btn-secondary mt-5\">Daha Fazlası </a>\n                    </div>\n\n\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubAbout>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
