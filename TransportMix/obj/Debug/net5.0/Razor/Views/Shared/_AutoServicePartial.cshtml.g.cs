#pragma checksum "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58ab5e6dddb0df19b5c3df7de9552b35b8dd784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AutoServicePartial), @"mvc.1.0.view", @"/Views/Shared/_AutoServicePartial.cshtml")]
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
#line 1 "E:\TransportMixAsp-master\TransportMix\Views\_ViewImports.cshtml"
using TransportMix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TransportMixAsp-master\TransportMix\Views\_ViewImports.cshtml"
using TransportMix.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\TransportMixAsp-master\TransportMix\Views\_ViewImports.cshtml"
using TransportMix.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58ab5e6dddb0df19b5c3df7de9552b35b8dd784", @"/Views/Shared/_AutoServicePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc13fedc03ed9a27bc37ccf761ca37ad7e3949a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AutoServicePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoServiceVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
 foreach (var item in Model.AutoServices)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 col-lg-4\">\n    <div class=\"auto-card\">\n        <div class=\"auto-car-img\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d58ab5e6dddb0df19b5c3df7de9552b35b8dd7843994", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 183, "~/image/", 183, 8, true);
#nullable restore
#line 8 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
AddHtmlAttributeValue("", 191, item.Image, 191, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"auto-card-detail\">\n            <h4>");
#nullable restore
#line 11 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
           Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <div class=\"auto-card-info d-flex align-items-center\">\n                <i class=\"fas fa-phone\"></i>\n                <div>\n                    <a class=\"d-block\"");
            BeginWriteAttribute("href", " href=\"", 479, "\"", 503, 2);
            WriteAttributeValue("", 486, "tel:", 486, 4, true);
#nullable restore
#line 15 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
WriteAttributeValue("", 490, item.Phone, 490, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                                                           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 16 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                     if (item.SecondaryPhone != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"d-block\"");
            BeginWriteAttribute("href", " href=\"", 619, "\"", 652, 2);
            WriteAttributeValue("", 626, "tel:", 626, 4, true);
#nullable restore
#line 18 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
WriteAttributeValue("", 630, item.SecondaryPhone, 630, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                                                    Write(item.SecondaryPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 18 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n            <div class=\"auto-card-info d-flex align-items-center\">\n                <i class=\"fas fa-envelope-open\"></i>\n                <div>\n");
#nullable restore
#line 24 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                     if (item.Email != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 937, "\"", 964, 2);
            WriteAttributeValue("", 944, "mailto:", 944, 7, true);
#nullable restore
#line 26 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
WriteAttributeValue("", 951, item.Email, 951, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                              Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 26 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n            <div class=\"auto-card-info d-flex align-items-center\">\n                <i class=\"fas fa-briefcase\"></i>\n                <div>\n                    <a href=\"#\">");
#nullable restore
#line 32 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </div>\n            </div>\n            <div class=\"auto-card-info d-flex align-items-center\">\n                <i class=\"fas fa-map-marked-alt\"></i>\n                <div>\n                    <a href=\"#\">");
#nullable restore
#line 38 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </div>\n            </div>\n            <div class=\"auto-card-icon\">\n");
#nullable restore
#line 42 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                 if (item.Facebook != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 1599, "\"", 1622, 1);
#nullable restore
#line 44 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
WriteAttributeValue("", 1606, item.Facebook, 1606, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <i class=\"fab fa-facebook-f\"></i>\n</a>");
#nullable restore
#line 46 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                 if (item.Instagram != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#\">\n    <i class=\"fab fa-instagram\"></i>\n</a>");
#nullable restore
#line 51 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                 if (item.Youtube != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 1851, "\"", 1873, 1);
#nullable restore
#line 54 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
WriteAttributeValue("", 1858, item.Youtube, 1858, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <i class=\"fab fa-youtube\"></i>\n</a>");
#nullable restore
#line 56 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>            ");
#nullable restore
#line 60 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_AutoServicePartial.cshtml"
                  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoServiceVM> Html { get; private set; }
    }
}
#pragma warning restore 1591