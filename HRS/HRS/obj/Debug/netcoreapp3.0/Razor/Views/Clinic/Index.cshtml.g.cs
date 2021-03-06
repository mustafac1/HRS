#pragma checksum "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755b78990696583818149c2a321ee2c39afa9707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clinic_Index), @"mvc.1.0.view", @"/Views/Clinic/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755b78990696583818149c2a321ee2c39afa9707", @"/Views/Clinic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d2351f77ed0a102b1111bf654daee94bc044ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Clinic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRS.ViewModel.ClinicViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
  
    ViewData["Title"] = "Klinik";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom red-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Klinik Ekleme Sayfası</h2>\r\n        <ol class=\"breadcrumb red-bg\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 393, 1);
#nullable restore
#line 12 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
WriteAttributeValue("", 366, Url.Action("Index","Home"), 366, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Anasayfa</a>
            </li>
            <li class=""breadcrumb-item active"">
                <strong>Klinik Ekle</strong>
            </li>
        </ol>
    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-6"">

            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Klinik Ekleme Formu</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
");
#nullable restore
#line 35 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
                     using (Html.BeginForm("Add", "Clinic", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-group row"">
                            <label class=""col-sm-2 col-form-label"">Klinik Adı</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" placeholder=""Örn: Acil Servis"" class=""form-control m-b"" name=""Name"">
                            </div>
                        </div>
                        <div class=""hr-line-dashed""></div>
                        <div class=""col-sm-4 col-sm-offset-2"">
                            <button type=""submit"" class=""btn btn-primary btn-sm""><i class=""fa fa-floppy-o""></i> Kaydet</button>
                        </div>
");
#nullable restore
#line 47 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>
        <div class=""col-lg-6"">

            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Klinik Tablosu</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">

                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Klinik Adı</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 74 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
                             foreach (var item in Model.Clinics)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 78 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n                                        <a class=\"btn btn-danger btn-rounded btn-outline\"");
            BeginWriteAttribute("href", " href=\"", 3070, "\"", 3124, 1);
#nullable restore
#line 80 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"
WriteAttributeValue("", 3077, Url.Action("Delete","Clinic", new { item.Id }), 3077, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Sil</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 83 "C:\Users\user\Desktop\HRS\HRS\Views\Clinic\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRS.ViewModel.ClinicViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
