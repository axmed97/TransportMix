#pragma checksum "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\EmailInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5913a93f97b61f48cf4ba0c079bfd181b2b11266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EmailInfo_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/EmailInfo/Index.cshtml")]
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
#line 1 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\_ViewImports.cshtml"
using TransportMix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\_ViewImports.cshtml"
using TransportMix.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\_ViewImports.cshtml"
using TransportMix.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\_ViewImports.cshtml"
using TransportMix.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5913a93f97b61f48cf4ba0c079bfd181b2b11266", @"/Areas/Admin/Views/EmailInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15cadf7a3ec1bb7937e5a43e0fa618c2946eb805", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EmailInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Emailnfos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\EmailInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["activeTab"] = "Email";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("title", async() => {
                WriteLiteral("\n    <h4 class=\"page-title text-uppercase font-medium font-14\">Auto Master</h4>\n");
            }
            );
            WriteLiteral(@"
<table class=""table table-hover table-striped table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th></th>
            <th>Email</th>
        </tr>
    </thead>
    <tbody>
            <tr>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 446, "\"", 486, 2);
            WriteAttributeValue("", 453, "/Admin/EmailInfo/Edit/", 453, 22, true);
#nullable restore
#line 21 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\EmailInfo\Index.cshtml"
WriteAttributeValue("", 475, Model.Id, 475, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning btn-block btn-lg\">\n                        <i class=\"fas fa-pencil-alt\"></i>\n                    </a>\n                </td>\n                <td>");
#nullable restore
#line 25 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\EmailInfo\Index.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Emailnfos> Html { get; private set; }
    }
}
#pragma warning restore 1591
