#pragma checksum "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80bbcb03ba2cfbf4f86ff1d1a03e62221dfa9cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewsPartial), @"mvc.1.0.view", @"/Views/Shared/_NewsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bbcb03ba2cfbf4f86ff1d1a03e62221dfa9cbe", @"/Views/Shared/_NewsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc13fedc03ed9a27bc37ccf761ca37ad7e3949a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NewsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsVM>
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
#line 3 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
 foreach (var item in Model.newlar)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"news-item\">\n    <div class=\"news-img\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80bbcb03ba2cfbf4f86ff1d1a03e62221dfa9cbe3888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 122, "~/image/", 122, 8, true);
#nullable restore
#line 7 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
AddHtmlAttributeValue("", 130, item.Image, 130, 13, false);

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
            WriteLiteral("\n    </div>\n    <div class=\"news-info\">\n        <div class=\"news-data\">\n            <span>");
#nullable restore
#line 11 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
             Write(item.PublishDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n        <h1 class=\"news-title\">");
#nullable restore
#line 13 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
                           Write(item.Name.Length>80?item.Name.Substring(0,80)+"...":item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <p class=\"news-text\">\n            ");
#nullable restore
#line 15 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
        Write(item.Content.Length>200?item.Content.Substring(0,200)+"...":item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 563, "\"", 595, 2);
            WriteAttributeValue("", 570, "/Home/DetailNews/", 570, 17, true);
#nullable restore
#line 17 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
WriteAttributeValue("", 587, item.Id, 587, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"news-link\">ard??n?? oxu</a>\n    </div>\n</div>");
#nullable restore
#line 19 "E:\TransportMixAsp-master\TransportMix\Views\Shared\_NewsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
