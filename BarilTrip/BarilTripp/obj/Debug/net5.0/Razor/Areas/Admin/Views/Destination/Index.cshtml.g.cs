#pragma checksum "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2c4d8f27b2da4be72802227f4c0a4968898eccf5f3f1cf9944501690e9383a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2c4d8f27b2da4be72802227f4c0a4968898eccf5f3f1cf9944501690e9383a5a", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e7a23828a381bc4ea0ce014cd825048f314e584c41f2eeb09e802b268a4b0d64", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tur Rotaları</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sitede Gör</th>
        <th>Sil</th>
        <th>Güncelle</th>
       
    
    </tr>
");
#nullable restore
#line 21 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 637, "\"", 695, 2);
            WriteAttributeValue("", 644, "/Destination/DestinationDetails/", 644, 32, true);
#nullable restore
#line 28 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 676, item.DestinationID, 676, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 765, "\"", 828, 2);
            WriteAttributeValue("", 772, "/Admin/Destination/DeleteDestination/", 772, 37, true);
#nullable restore
#line 29 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 809, item.DestinationID, 809, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil </a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 894, "\"", 957, 2);
            WriteAttributeValue("", 901, "/Admin/Destination/UpdateDestination/", 901, 37, true);
#nullable restore
#line 30 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 938, item.DestinationID, 938, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\n");
#nullable restore
#line 32 "C:\Users\brsha\OneDrive\Masaüstü\PROJEMM ASIL\BarilTripp\BarilTripp\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Destination/AddDestination\" class=\"btn btn-outline-primary\">Yeni Tur Rotası</a>\r\n\r\n");
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
