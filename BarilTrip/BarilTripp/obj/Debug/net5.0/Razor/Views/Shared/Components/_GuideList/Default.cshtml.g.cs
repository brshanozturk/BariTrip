#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8f2a507c2436673eb39e517200fefafea39de25b335ca8f29cdb30be8cb142e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GuideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GuideList/Default.cshtml")]
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
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8f2a507c2436673eb39e517200fefafea39de25b335ca8f29cdb30be8cb142e1", @"/Views/Shared/Components/_GuideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"86c8163fda925635cd17d8d2e76da7dd97c7d5893af5811275a93cf284c58d61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__GuideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-12 col-xl-4\">\r\n    <div class=\"card h-100\">\r\n        <div class=\"card-header pb-0 p-3\">\r\n            <h6 class=\"mb-0\">Tur Rehberlerimiz</h6>\r\n        </div>\r\n        <div class=\"card-body p-3\">\r\n            <ul class=\"list-group\">\r\n");
#nullable restore
#line 10 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml"
                 foreach (var item in Model)
                {           
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item border-0 d-flex align-items-center px-0 mb-2\">\r\n                    <div class=\"avatar me-3\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 572, 1);
#nullable restore
#line 15 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml"
WriteAttributeValue("", 561, item.Image, 561, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"kal\" class=\"border-radius-lg shadow\">\r\n                    </div>\r\n                    <div class=\"d-flex align-items-start flex-column justify-content-center\">\r\n                        <h6 class=\"mb-0 text-sm\">");
#nullable restore
#line 18 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p class=\"mb-0 text-xs\">");
#nullable restore
#line 19 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <a class=\"btn btn-link pe-3 ps-0 mb-0 ms-auto\" href=\"javascript:;\">Profil</a>\r\n                </li>\r\n");
#nullable restore
#line 23 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_GuideList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
