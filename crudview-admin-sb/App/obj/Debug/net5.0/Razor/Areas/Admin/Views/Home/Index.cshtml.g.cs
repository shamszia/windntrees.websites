#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e429b3db79ae2d3a913ec121df2106cf71c84e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Application.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Application.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Application.Core.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Application.Core.Models.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using SharedLibrary.Core.Resources.Global;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e429b3db79ae2d3a913ec121df2106cf71c84e0", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/ActivityHistory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 7 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
      Write(LocaleResources.Core.Views.ActivityHistory.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <script type=\"text/html\" id=\"headings\">\r\n        <tr>\r\n            <th class=\"col-2 order-0\" scope=\"col\">\r\n                <span class=\"d-flex align-content-start\"");
                BeginWriteAttribute("title", " title=\"", 332, "\"", 407, 1);
#nullable restore
#line 12 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 340, LocaleResources.Core.Contents.Account.ActivityHistory.ActivityTime, 340, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 12 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                                Write(LocaleResources.Core.Contents.Account.ActivityHistory.ActivityTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </th>\r\n            <th class=\"col-2 order-1\" scope=\"col\">\r\n                <span class=\"d-flex align-content-start\"");
                BeginWriteAttribute("title", " title=\"", 612, "\"", 683, 1);
#nullable restore
#line 15 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 620, LocaleResources.Core.Contents.Account.ActivityHistory.Activity, 620, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 15 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                            Write(LocaleResources.Core.Contents.Account.ActivityHistory.Activity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </th>\r\n            <th class=\"col-6 order-2\" scope=\"col\">\r\n                <span class=\"d-flex align-content-start\"");
                BeginWriteAttribute("title", " title=\"", 884, "\"", 954, 1);
#nullable restore
#line 18 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 892, LocaleResources.Core.Contents.Account.ActivityHistory.Request, 892, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 18 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                           Write(LocaleResources.Core.Contents.Account.ActivityHistory.Request);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </th>\r\n            <th class=\"col-2 order-3\" scope=\"col\">\r\n                <span class=\"d-flex align-content-start\"");
                BeginWriteAttribute("title", " title=\"", 1154, "\"", 1226, 1);
#nullable restore
#line 21 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1162, LocaleResources.Core.Contents.Account.ActivityHistory.IPAddress, 1162, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                             Write(LocaleResources.Core.Contents.Account.ActivityHistory.IPAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
            </th>
        </tr>
    </script>

    <script type=""text/html"" id=""rows"">
        <tr>
            <td><span class=""d-flex align-content-start"" data-bind=""text: new DateParser().parseDate(ActivityTime, true).toString('yyyy-MM-dd HH:mm:ss')""></span></td>
            <td><span class=""d-flex align-content-start"" data-bind=""text: Activity""></span></td>
            <td><span class=""d-flex align-content-start"" data-bind=""text: Request""></span></td>
            <td><span class=""d-flex align-content-start"" data-bind=""text: Ipaddress""></span></td>
        </tr>
    </script>
");
            }
            );
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2 class=\"d-flex align-content-start\">");
#nullable restore
#line 37 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
                                      Write(LocaleResources.Core.Views.ActivityHistory.Index.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"d-flex align-content-start\">");
#nullable restore
#line 38 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
                                     Write(LocaleResources.Core.Views.ActivityHistory.Index.PageD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 41 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
Write(Controls.Core.Grid.GridComposer.composeStandardActions(null, "", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 43 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
Write(Controls.Core.Grid.GridComposer.composeStandardListing(null, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 45 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Home\Index.cshtml"
Write(Controls.Core.Grid.GridComposer.composeGrid(null, null, null, null, null, null, null, null, null, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e429b3db79ae2d3a913ec121df2106cf71c84e012761", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script type=""text/javascript"">

        var crudView = new CRUDView({
            'uri': '/admin/home',
            'observer': new CRUDObserver({ 'contentType': new ActivityHistory({}), 'messages': intialize(new MessageRepository()) })
        });
        crudView.getObserverObject().setListSource(crudView);

        $(function () {

            try {

                ko.applyBindings(crudView.getObserverObject());
            }
            catch (e) {

                console.log(e.message);
            }

            crudView.list(1);
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
