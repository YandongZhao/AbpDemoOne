#pragma checksum "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e488c7928a29f7d715ca8b7aab0adc1d8b400e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RightSideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RightSideBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RightSideBar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RightSideBar_Default))]
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
#line 1 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
using AbpDemoOne.Configuration.Ui;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e488c7928a29f7d715ca8b7aab0adc1d8b400e", @"/Views/Shared/Components/RightSideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9442158294212dae8f00f48cdcd7493360b2e780", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RightSideBar_Default : AbpDemoOne.Web.Views.AbpDemoOneRazorPage<AbpDemoOne.Web.Views.Shared.Components.RightSideBar.RightSideBarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(116, 189, true);
            WriteLiteral("<aside id=\"rightsidebar\" class=\"right-sidebar\">\n    <ul class=\"nav nav-tabs tab-nav-right\" role=\"tablist\">\n        <li role=\"presentation\" class=\"active\"><a href=\"#skins\" data-toggle=\"tab\">");
            EndContext();
            BeginContext(306, 10, false);
#line 5 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                             Write(L("Skins"));

#line default
#line hidden
            EndContext();
            BeginContext(316, 80, true);
            WriteLiteral("</a></li>\n        <li role=\"presentation\"><a href=\"#settings\" data-toggle=\"tab\">");
            EndContext();
            BeginContext(397, 13, false);
#line 6 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                 Write(L("Settings"));

#line default
#line hidden
            EndContext();
            BeginContext(410, 175, true);
            WriteLiteral("</a></li>\n    </ul>\n    <div class=\"tab-content\">\n        <div role=\"tabpanel\" class=\"tab-pane fade in active in active\" id=\"skins\">\n            <ul class=\"demo-choose-skin\">\n");
            EndContext();
#line 11 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                 foreach (var theme in UiThemes.All)
                {

#line default
#line hidden
            BeginContext(656, 36, true);
            WriteLiteral("                    <li data-theme=\"");
            EndContext();
            BeginContext(693, 14, false);
#line 13 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                               Write(theme.CssClass);

#line default
#line hidden
            EndContext();
            BeginContext(707, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 708, "\"", 780, 1);
#line 13 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
WriteAttributeValue("", 716, theme.CssClass == Model.CurrentTheme.CssClass ? "active" : "", 716, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(781, 30, true);
            WriteLiteral(">\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 811, "\"", 834, 1);
#line 14 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
WriteAttributeValue("", 819, theme.CssClass, 819, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(835, 38, true);
            WriteLiteral("></div>\n                        <span>");
            EndContext();
            BeginContext(874, 10, false);
#line 15 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                         Write(theme.Name);

#line default
#line hidden
            EndContext();
            BeginContext(884, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 17 "E:\Study\AbpDemoOne\4.6.0\aspnet-core\src\AbpDemoOne.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(936, 2275, true);
            WriteLiteral(@"            </ul>
        </div>
        <div role=""tabpanel"" class=""tab-pane fade"" id=""settings"">
            <div class=""demo-settings"">
                <p>GENERAL SETTINGS</p>
                <ul class=""setting-list"">
                    <li>
                        <span>Report Panel Usage</span>
                        <div class=""switch"">
                            <label><input type=""checkbox"" checked><span class=""lever""></span></label>
                        </div>
                    </li>
                    <li>
                        <span>Email Redirect</span>
                        <div class=""switch"">
                            <label><input type=""checkbox""><span class=""lever""></span></label>
                        </div>
                    </li>
                </ul>
                <p>SYSTEM SETTINGS</p>
                <ul class=""setting-list"">
                    <li>
                        <span>Notifications</span>
                        <div class=""switch"">
                     ");
            WriteLiteral(@"       <label><input type=""checkbox"" checked><span class=""lever""></span></label>
                        </div>
                    </li>
                    <li>
                        <span>Auto Updates</span>
                        <div class=""switch"">
                            <label><input type=""checkbox"" checked><span class=""lever""></span></label>
                        </div>
                    </li>
                </ul>
                <p>ACCOUNT SETTINGS</p>
                <ul class=""setting-list"">
                    <li>
                        <span>Offline</span>
                        <div class=""switch"">
                            <label><input type=""checkbox""><span class=""lever""></span></label>
                        </div>
                    </li>
                    <li>
                        <span>Location Permission</span>
                        <div class=""switch"">
                            <label><input type=""checkbox"" checked><span class=""lever""></span></label>
        ");
            WriteLiteral("                </div>\n                    </li>\n                </ul>\n                \n                <p style=\"color: red;\">This settings are just for demonstration!</p>\n            </div>\n        </div>\n    </div>\n</aside>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AbpDemoOne.Web.Views.Shared.Components.RightSideBar.RightSideBarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591