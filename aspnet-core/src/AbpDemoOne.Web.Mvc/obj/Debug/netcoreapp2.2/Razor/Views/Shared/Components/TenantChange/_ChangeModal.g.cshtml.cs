#pragma checksum "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d14178e7a1fdd4a2d70d27556cee21f9f1dcdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TenantChange__ChangeModal), @"mvc.1.0.view", @"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml", typeof(AspNetCore.Views_Shared_Components_TenantChange__ChangeModal))]
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
#line 1 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#line 2 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using AbpDemoOne.Web.Models.Common.Modals;

#line default
#line hidden
#line 3 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using AbpDemoOne.Web.Views.Shared.Components.TenantChange;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5d14178e7a1fdd4a2d70d27556cee21f9f1dcdf", @"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9442158294212dae8f00f48cdcd7493360b2e780", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TenantChange__ChangeModal : AbpDemoOne.Web.Views.AbpDemoOneRazorPage<ChangeModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TenantChangeForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Shared/Components/TenantChange/_ChangeModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(179, 102, false);
#line 8 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("ChangeTenant"))));

#line default
#line hidden
            EndContext();
            BeginContext(281, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(312, 493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d14178e7a1fdd4a2d70d27556cee21f9f1dcdf6294", async() => {
                BeginContext(389, 155, true);
                WriteLiteral("\n        <div class=\"form-group form-float\">\n            <div class=\"form-line\">\n                <input class=\"form-control\" type=\"text\" name=\"TenancyName\"");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 544, "\"", 591, 1);
#line 14 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
WriteAttributeValue("", 556, AbpTenantBase.MaxTenancyNameLength, 556, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 592, "\"", 618, 1);
#line 14 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
WriteAttributeValue("", 600, Model.TenancyName, 600, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(619, 44, true);
                WriteLiteral(">\n                <label class=\"form-label\">");
                EndContext();
                BeginContext(664, 16, false);
#line 15 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                                     Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(680, 76, true);
                WriteLiteral("</label>\n            </div>\n        </div>\n        <span class=\"help-block\">");
                EndContext();
                BeginContext(757, 29, false);
#line 18 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                            Write(L("LeaveEmptyToSwitchToHost"));

#line default
#line hidden
                EndContext();
                BeginContext(786, 12, true);
                WriteLiteral("</span>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(805, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            BeginContext(815, 74, false);
#line 22 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(889, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(891, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d14178e7a1fdd4a2d70d27556cee21f9f1dcdf10692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 24 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 1, true);
            WriteLiteral("\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangeModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
