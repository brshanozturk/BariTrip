#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f784d8266117a0099b69509ed4dc340dc22f2a2c860f49a2600d8f94050e483b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PopularDestination_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PopularDestination/Default.cshtml")]
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
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f784d8266117a0099b69509ed4dc340dc22f2a2c860f49a2600d8f94050e483b", @"/Views/Shared/Components/_PopularDestination/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"86c8163fda925635cd17d8d2e76da7dd97c7d5893af5811275a93cf284c58d61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__PopularDestination_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
﻿

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Seyahatini Planla</h6>
            <h3 class=""hny-title"">Popüler Tur Rotaları</h3>
        </div>
        <div class=""row bottom-ab-grids"">
            <!--/row-grids-->
");
#nullable restore
#line 11 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 808, "\"", 825, 1);
#nullable restore
#line 18 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
WriteAttributeValue("", 814, item.Image, 814, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:120px\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 877, "\"", 883, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n                                <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\n                                    <h4>");
#nullable restore
#line 21 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                    <p>");
#nullable restore
#line 22 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
                                  Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    <div class=\"dst-btm\">\n                                        <h6");
            BeginWriteAttribute("class", " class=\"", 1224, "\"", 1232, 0);
            EndWriteAttribute();
            WriteLiteral("> Başlayan fiyatlarla </h6>\n                                        <span>");
#nullable restore
#line 25 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</span>\n                                    </div>\n                                    <p class=\"sub-para\">");
#nullable restore
#line 27 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                            </div>\n                        </a>\n                    </div>\n                </div>\n");
#nullable restore
#line 33 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Views\Shared\Components\_PopularDestination\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--//row-grids-->\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
