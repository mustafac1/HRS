#pragma checksum "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d1d75a77216272de252f5965449a94edff2157f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workers_Index), @"mvc.1.0.view", @"/Views/Workers/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\HRS\HRS\Views\_ViewImports.cshtml"
using HRS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\HRS\HRS\Views\_ViewImports.cshtml"
using HRS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d1d75a77216272de252f5965449a94edff2157f", @"/Views/Workers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d2351f77ed0a102b1111bf654daee94bc044ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Workers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRS.ViewModel.WorkersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
  
    ViewData["Title"] = "İşçiler";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom red-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>İşçiler Sayfası</h2>\r\n        <ol class=\"breadcrumb red-bg\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 355, "\"", 389, 1);
#nullable restore
#line 12 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
WriteAttributeValue("", 362, Url.Action("Index","Home"), 362, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Anasayfa</a>
            </li>
            <li class=""breadcrumb-item active"">
                <strong>İşçiler</strong>
            </li>
        </ol>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12"">

        <div class=""m-1 text-right"">
            <a class=""btn btn-success btn-rounded btn-outline""");
            BeginWriteAttribute("href", " href=\"", 721, "\"", 756, 1);
#nullable restore
#line 25 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
WriteAttributeValue("", 728, Url.Action("Add","Workers"), 728, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-user-plus""></i> İşçi Ekle</a>
        </div>

        <div class=""ibox"">
            <div class=""ibox-title"">
                <h5>İşçiler Tablosu</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""close-link"">
                        <i class=""fa fa-times""></i>
                    </a>
                </div>
            </div>
            <div class=""ibox-content"">

                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>İşçi Adı</th>
                            <th>İşçi Soyadı</th>
                            <th>İşçi Cinsiyet</th>
                            <th>İşçi TC Kimlik Numarası</th>
                            <th>İşçi Doğum Tarihi</th>
                            <th>İşçi Tel</th>
 ");
            WriteLiteral(@"                           <th>İşçi Mail</th>
                            <th>İşçi Kullanıcı Adı</th>
                            <th>İşçi Grubu</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 60 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                         foreach (var item in Model.WokerAndRoles)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>#</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 67 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                                     if (item.Gender == "E")
                                    {
                                        Write("Erkek");
                                    }
                                    else
                                    {
                                        Write("Kadın");
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 76 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.TcNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 77 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.DateOfBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 78 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 79 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 80 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 81 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                               Write(item.RolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\"><a class=\"btn btn-info btn-rounded btn-outline\"");
            BeginWriteAttribute("href", " href=\"", 3289, "\"", 3353, 1);
#nullable restore
#line 82 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
WriteAttributeValue("", 3296, Url.Action("Edit","Workers", new { workerid = item.Id }), 3296, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i> Düzenle</a></td>\r\n                                <td class=\"text-center\"><a class=\"btn btn-danger btn-rounded btn-outline\"");
            BeginWriteAttribute("href", " href=\"", 3505, "\"", 3559, 1);
#nullable restore
#line 83 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
WriteAttributeValue("", 3512, Url.Action("Delete","Workers",new { item.Id }), 3512, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Sil</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\user\Desktop\HRS\HRS\Views\Workers\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRS.ViewModel.WorkersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
