#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f0e49b0d8baa2c6b7a5c5ef563d906225354392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Lists_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Lists/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f0e49b0d8baa2c6b7a5c5ef563d906225354392", @"/Areas/Admin/Views/Lists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Lists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Color.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Category.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Unit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Manufacturer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/CompanyType.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/ReferenceType.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/AdvertisementPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/AdvertisementLocation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 3 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
      Write(LocaleResources.Core.Views.Lists.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <script type=\"text/html\" id=\"headings\">\r\n        <tr>\r\n            <th class=\"col-5 order-0\" scope=\"col\">\r\n                <span class=\"d-flex align-content-start\"");
                BeginWriteAttribute("title", " title=\"", 254, "\"", 303, 1);
#nullable restore
#line 8 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 262, LocaleResources.Core.Contents.Color.Name, 262, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 8 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                      Write(LocaleResources.Core.Contents.Color.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </th>\r\n            <th class=\"col-5 order-1\" scope=\"col\">\r\n                <span class=\"d-flex align-content-start\"");
                BeginWriteAttribute("title", " title=\"", 482, "\"", 538, 1);
#nullable restore
#line 11 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 490, LocaleResources.Core.Contents.Color.Description, 490, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 11 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                             Write(LocaleResources.Core.Contents.Color.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
            </th>
            <th class=""col-2 order-2"" scope=""col"">&nbsp;</th>
        </tr>
    </script>

    <script type=""text/html"" id=""rows"">
        <tr>
            <td><span class=""d-flex align-content-start"" data-bind=""text: Name()""></span></td>
            <td><span class=""d-flex align-content-start"" data-bind=""text: Description()""></span></td>
            <td>
                <div class=""hidden-phone visible-desktop action-buttons"">
                    <a class=""green"" href=""#"" data-bind=""click: function(data, event) { $parent.resetFormForEditing($index); }"" data-toggle=""modal"" data-target=""#__form""");
                BeginWriteAttribute("title", " title=\"", 1227, "\"", 1290, 1);
#nullable restore
#line 23 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 1235, SharedLibrary.Core.Resources.Global.FormMessages.EditD, 1235, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-edit text-success\"></i>");
#nullable restore
#line 23 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                                                                                                                                                                                            Write(SharedLibrary.Core.Resources.Global.FormMessages.Edit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    <a class=\"red\" href=\"#\" data-bind=\"click: function(data, event) { $parent.delete($data); }\"");
                BeginWriteAttribute("title", " title=\"", 1502, "\"", 1567, 1);
#nullable restore
#line 24 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 1510, SharedLibrary.Core.Resources.Global.FormMessages.DeleteD, 1510, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-times text-danger\"></i>");
#nullable restore
#line 24 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                                                                                                                                    Write(SharedLibrary.Core.Resources.Global.FormMessages.Delete);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    <a class=\"red\" href=\"#\" data-bind=\"click: function(data, event) { $parent.read($data.Uid); }\"");
                BeginWriteAttribute("title", " title=\"", 1783, "\"", 1847, 1);
#nullable restore
#line 25 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 1791, SharedLibrary.Core.Resources.Global.FormMessages.Reload, 1791, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-times text-danger\"></i>");
#nullable restore
#line 25 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                                                                                                                                     Write(SharedLibrary.Core.Resources.Global.FormMessages.Reload);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                </div>
            </td>
        </tr>
    </script>

    <script type=""text/html"" id=""formcontent"">
        <div class=""form-row form-group"">
            <div class=""col-4 order-0"">
                <label class=""control-label d-flex align-content-start"" for=""Name"">
                    ");
#nullable restore
#line 35 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
               Write(LocaleResources.Core.Contents.Color.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control col-12\" data-bind=\"value: $parent.EditMode() ? Name : Name\" id=\"Name\" type=\"text\"");
                BeginWriteAttribute("title", " title=\"", 2455, "\"", 2504, 1);
#nullable restore
#line 37 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 2463, LocaleResources.Core.Contents.Color.Name, 2463, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       maxlength=\"50\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2544, "\"", 2558, 0);
                EndWriteAttribute();
                WriteLiteral(@" /><span class=""error""
                                                                                  data-bind=""validationMessage: Name""></span>
            </div>
            <div class=""col-8 order-1"">
                <label class=""control-label d-flex align-content-start"" for=""Description"">
                    ");
#nullable restore
#line 43 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
               Write(LocaleResources.Core.Contents.Color.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control col-12\" data-bind=\"value: $parent.EditMode() ? Description : Description\" id=\"Description\" type=\"text\"");
                BeginWriteAttribute("title", " title=\"", 3104, "\"", 3160, 1);
#nullable restore
#line 45 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
WriteAttributeValue("", 3112, LocaleResources.Core.Contents.Color.Description, 3112, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       maxlength=\"255\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3201, "\"", 3215, 0);
                EndWriteAttribute();
                WriteLiteral(" /><span class=\"error\"\r\n                                                                                   data-bind=\"validationMessage: Description\"></span>\r\n            </div>\r\n        </div>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
Write(Controls.Core.Grid.GridComposer.composeStandardActions(null, "#__form", false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 55 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
Write(Controls.Core.Grid.GridComposer.composeStandardListing(null, "#__form"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"container-fluid row\">\r\n\r\n    <div class=\"col-3 order-0 justify-content-start\" data-bind=\"with: getCurrent().getObserverObject()\">\r\n        <div class=\"container pt-4\">\r\n            <h4 class=\"d-flex align-content-start p-2\">");
#nullable restore
#line 61 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                  Write(LocaleResources.Core.Views.Lists.Index.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <ul class=""outer-items-list"" data-bind=""foreach: $root.getCRUDS()"">
                <li class=""d-flex align-content-start p-2""><a data-bind=""click: function(data,event) { $root.selectCRUD({'crudindex': $index() }); list(1); }"" href=""#""><span data-bind=""text: getName()""></span> </a></li>
            </ul>
        </div>
    </div>

    <div class=""col-9 order-1"">
        <div class=""row align-items-center"">
            <div class=""col-6 order-0 d-flex justify-content-start"">
                <span class=""h1"" data-bind=""text: getCurrent().getObserverObject().getName()""></span>
            </div>
            <div class=""col-6 order-1 d-flex justify-content-end"">
                <nav");
            BeginWriteAttribute("aria-label", " aria-label=\"", 4592, "\"", 4605, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <ul class=\"pagination\">\r\n                        <li class=\"order-first page-item\"><a class=\"page-link\" data-bind=\"click: function(data,event) { $root.prevCRUD(); }\" href=\"#\">");
#nullable restore
#line 76 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                                                                 Write(SharedLibrary.Core.Resources.Global.FormMessages.PrevPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"order-last page-item\"><a class=\"page-link\" data-bind=\"click: function(data,event) { $root.nextCRUD(); }\" href=\"#\">");
#nullable restore
#line 77 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                                                                Write(SharedLibrary.Core.Resources.Global.FormMessages.NextPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                    </ul>
                </nav>
            </div>
        </div>
        
        <p class=""d-flex align-content-start"">
            <span data-bind=""text: getCurrent().getObserverObject().getTitle()""></span>
        </p>

        <section id=""observer-section"" data-bind=""with: getCurrent().getObserverObject().getObserverObject()"">
            
            ");
#nullable restore
#line 89 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
       Write(Controls.Core.Grid.GridComposer.composeGrid(null, "well", null, null, null, null, null, null, null, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <section data-bind=\"if: $root.getCurrent().getObserverObject().getType() === \'CRUDView\'\">\r\n\r\n                ");
#nullable restore
#line 93 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
           Write(Controls.Core.Form.FormComposer.composeForm("__form", null, null, null, "<div data-bind=\"template: {name: 'formcontent' }\"></div>", null, null, null, null, true, false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </section>\r\n\r\n        </section>\r\n\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439222274", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439223461", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439224648", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439225835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439227022", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439228209", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439229396", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e49b0d8baa2c6b7a5c5ef563d90622535439230583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n\r\n        var cruds = CRUDSList({\r\n                \'cruds\': [\r\n                    new CRUDView({\r\n                        \'name\': \'");
#nullable restore
#line 118 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.Color.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 118 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                           Write(LocaleResources.Core.Views.Lists.Color.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/color', 'observer': new CRUDObserver({ 'contentType': new Color({}), 'messages': intialize(new MessageRepository()) })
                    }),
                    new CRUDView({
                        'name': '");
#nullable restore
#line 122 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.Category.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 122 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                              Write(LocaleResources.Core.Views.Lists.Category.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/category',
                        'observer': new CRUDObserver({ 'contentType': new Category({}), 'messages': intialize(new MessageRepository()) })
                    }),
                    new CRUDView({
                        'name': '");
#nullable restore
#line 127 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.Unit.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 127 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                          Write(LocaleResources.Core.Views.Lists.Unit.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/unit',
                        'observer': new CRUDObserver({ 'contentType': new Unit({}), 'messages': intialize(new MessageRepository()) })
                    }),
                    new CRUDView({
                        'name': '");
#nullable restore
#line 132 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.Manufacturer.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 132 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                  Write(LocaleResources.Core.Views.Lists.Manufacturer.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/manufacturer',
                        'observer': new CRUDObserver({ 'contentType': new Manufacturer({}), 'messages': intialize(new MessageRepository()) })
                    }),
                    new CRUDView({
                        'name': '");
#nullable restore
#line 137 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.CompanyType.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 137 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                 Write(LocaleResources.Core.Views.Lists.CompanyType.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/companytype',
                        'observer': new CRUDObserver({ 'contentType': new CompanyType({}), 'messages': intialize(new MessageRepository()) })
                    }),
                    new CRUDView({
                        'name': '");
#nullable restore
#line 142 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.AdvertisementLocation.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 142 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                           Write(LocaleResources.Core.Views.Lists.AdvertisementLocation.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/advertisementlocation',
                        'observer': new CRUDObserver({ 'contentType': new AdvertisementLocation({}), 'messages': intialize(new MessageRepository()) })
                    }),
                    new CRUDView({
                        'name': '");
#nullable restore
#line 147 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                            Write(LocaleResources.Core.Views.Lists.AdvertisementPage.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'title\': \'");
#nullable restore
#line 147 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Lists\Index.cshtml"
                                                                                                       Write(LocaleResources.Core.Views.Lists.AdvertisementPage.Index.PageD);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        'uri': '/admin/advertisementpage',
                        'observer': new CRUDObserver({ 'contentType': new AdvertisementPage({}), 'messages': intialize(new MessageRepository()) })
                    })
                ],
                'observer': new ObjectObserver({})
            });


        $(function () {

            try {

                ko.applyBindings(cruds);
            }
            catch (e) {

                console.log(e.message);
            }

            cruds.getCurrent().getObject().list(1);
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