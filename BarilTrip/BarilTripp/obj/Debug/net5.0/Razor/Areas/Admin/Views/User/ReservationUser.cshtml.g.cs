#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "be416106eda6b3947963f17bc1d635739d19a5bec3645accbcfb603f000c006f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ReservationUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
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
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"be416106eda6b3947963f17bc1d635739d19a5bec3645accbcfb603f000c006f", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cc468607d2c246f365301e51b8887346374cd5140492aa186aa9fd1bec5e247b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_ReservationUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
  
    ViewData["Title"] = "ReservationUser";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ReservationUser</h1>

<h1>Kullanıcının Geçmiş Rezervasyonları</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Misafir Ad Soyad</th>
        <th>Rota</th>
        <th>Kişi Sayısı</th>
        <th>Tarih</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
     foreach (var item in Model)
    {
        { count += 1; }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>###</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
            Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\User\ReservationUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
