#pragma checksum "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a821b9fc21e2571ff7d1d54da0c6187a132f79c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AutoService_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/AutoService/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a821b9fc21e2571ff7d1d54da0c6187a132f79c", @"/Areas/Admin/Views/AutoService/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15cadf7a3ec1bb7937e5a43e0fa618c2946eb805", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AutoService_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoService>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    ViewData["activeTab"] = "Service";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("title", async() => {
                WriteLiteral("\n    <h4 class=\"page-title text-uppercase font-medium font-14\">Auto Service</h4>\n");
            }
            );
            WriteLiteral("\n<dl>\n    <dt>Image</dt>\n    <dd>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a821b9fc21e2571ff7d1d54da0c6187a132f79c5111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 273, "~/image/", 273, 8, true);
#nullable restore
#line 13 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
AddHtmlAttributeValue("", 281, Model.Image, 281, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</dd>\n    <dt>Company Name</dt>\n    <dd>");
#nullable restore
#line 15 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Phone</dt>\n    <dd>");
#nullable restore
#line 17 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Secondary Phone</dt>\n    <dd>");
#nullable restore
#line 19 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.SecondaryPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Email</dt>\n    <dd>");
#nullable restore
#line 21 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Description</dt>\n    <dd>");
#nullable restore
#line 23 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Address</dt>\n    <dd>");
#nullable restore
#line 25 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Facebook</dt>\n    <dd>");
#nullable restore
#line 27 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>Instagram</dt>\n    <dd>");
#nullable restore
#line 29 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    <dt>YouTube</dt>\n    <dd>");
#nullable restore
#line 31 "E:\TransportMixAsp-master\TransportMix\Areas\Admin\Views\AutoService\Detail.cshtml"
   Write(Model.Youtube);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n</dl>\n\n<a href=\"/Admin/AutoService/Index\" class=\"btn btn-outline-danger btn-lg btn-block\">Return</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoService> Html { get; private set; }
    }
}
#pragma warning restore 1591