#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2839dbbc0c7a4aa9329d08fff55101955d85f494985c2ccb55b91fff8d6c0ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\_ViewImports.cshtml"
using BarilTripp.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2839dbbc0c7a4aa9329d08fff55101955d85f494985c2ccb55b91fff8d6c0ec8", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cc468607d2c246f365301e51b8887346374cd5140492aa186aa9fd1bec5e247b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
﻿

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    img {
        border-radius: 50%;
    }
</style>

<h1>Rehber Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Görsel</th>
        <th>Ad Soyad</th>
        <th>Açıklama</th>
        <th>Durum</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 26 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 590, "\"", 607, 1);
#nullable restore
#line 31 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 596, item.Image, 596, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
#nullable restore
#line 36 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
              
                if (item.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 821, "\"", 868, 2);
            WriteAttributeValue("", 828, "/Admin/Guide/ChangeToFalse/", 828, 27, true);
#nullable restore
#line 39 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 855, item.GuideID, 855, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 40 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1054, 2);
            WriteAttributeValue("", 1015, "/Admin/Guide/ChangeToTrue/", 1015, 26, true);
#nullable restore
#line 43 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1041, item.GuideID, 1041, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap</a></td>\r\n");
#nullable restore
#line 44 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td><a href=\"/Admin/Guide/EditGuide/\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Guide/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Girişi</a>\r\n");
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
