#pragma checksum "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Modals\_ModalHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3dead440bd0a9fc83a8af257a49aa75f70a9113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Modals__ModalHeader), @"mvc.1.0.view", @"/Views/Shared/Modals/_ModalHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Modals/_ModalHeader.cshtml", typeof(AspNetCore.Views_Shared_Modals__ModalHeader))]
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
#line 1 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Modals\_ModalHeader.cshtml"
using AbpDemoOne.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3dead440bd0a9fc83a8af257a49aa75f70a9113", @"/Views/Shared/Modals/_ModalHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9442158294212dae8f00f48cdcd7493360b2e780", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Modals__ModalHeader : AbpDemoOne.Web.Views.AbpDemoOneRazorPage<ModalHeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 160, true);
            WriteLiteral("<div class=\"modal-header\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\"></button>\n    <h4 class=\"modal-title\">\n        <span>");
            EndContext();
            BeginContext(232, 21, false);
#line 6 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Modals\_ModalHeader.cshtml"
         Write(Html.Raw(Model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(253, 25, true);
            WriteLiteral("</span>\n    </h4>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModalHeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
