#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Unit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af72a27d860bd6426eea3c7e49891af19419bf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Unit_Index), @"mvc.1.0.view", @"/Views/Unit/Index.cshtml")]
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
#line 1 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Application.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Application.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Application.Core.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Application.Core.Models.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using SharedLibrary.Core.Resources.Global;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af72a27d860bd6426eea3c7e49891af19419bf4", @"/Views/Unit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Views/_ViewImports.cshtml")]
    public class Views_Unit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Unit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"observer-section\">\r\n    <div class=\"card\">\r\n        ");
#nullable restore
#line 3 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Unit\Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""card-header"">
            <span data-bind=""visible: getProcessing()""><i class=""fa fa-cog fa-spin fa-2x""></i></span>
            <span data-bind=""if: getResultMessage().length > 0"" class=""alert""><span data-bind=""text: getResultMessage()""></span></span>
            <div data-bind=""if: getErrors().length > 0"">
                <ul class=""errorlist"" data-bind=""foreach: { data: getObservableErrors(), as: 'error' }"">
                    <li class=""alert""><span data-bind=""text: errField""></span> <span data-bind=""text: errMessage""></span></li>
                </ul>
            </div>
        </div>

        <div class=""card-body"">
            <div class=""table-responsive"">
                <div class=""bootstrap-table"">
                    <div class=""fixed-table-toolbar"">
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <span class=""input-group-btn"">
                                    <button cl");
            WriteLiteral(@"ass=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { resetForm(); }"" data-toggle=""modal"" data-target=""#inputForm"">new</button>
                                </span>
                                <input class=""form-control"" data-bind=""value: getObservableKeyword()"" type=""text"" placeholder=""keyword"" />
                                <span class=""input-group-btn"">
                                    <button class=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { list(1); }"">find / load</button>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class=""fixed-table-container"">
                        <div class=""fixed-table-header""></div><div class=""fixed-table-body"">
                            <table class=""table table-hover grid-style-0"">
                                <tr>
                                    <th class=""col-5"">
            ");
            WriteLiteral(@"                            <span title=""name"">Name</span>
                                    </th>
                                    <th class=""col-5"">
                                        <span title=""description"">Description</span>
                                    </th>
                                    <th class=""col-2""> </th>
                                </tr>
                                <tbody data-bind=""foreach: { data: getObservableRecords(), as: 'record' }"">
                                    <tr>
                                        <td data-bind=""text: Name()""></td>
                                        <td data-bind=""text: Description()""></td>
                                        <td>
                                            <div class=""hidden-phone visible-desktop action-buttons"">
                                                <a class=""green"" href=""#"" title=""edit"" data-bind=""click: function(data, event) { $parents[0].resetFormForEditing($index); }"" dat");
            WriteLiteral(@"a-toggle=""modal"" data-target=""#inputForm""><i class=""fa fa-edit text-success""></i><span> edit </span></a>
                                                <a class=""red"" href=""#"" title=""delete"" data-bind=""click: function(data, event) { $parents[0].delete(data); }""><i class=""fa fa-times text-danger""></i><span> delete </span></a>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""clearfix""></div>
            <div class=""form-group form-row"">
                <div class=""col-6 order-0"">
                    <div class=""input-group justify-content-start"">
                        <span class=""input-group-prepend"">
                            <span class=""input-group-text"">List Size</span>
                        </sp");
            WriteLiteral("an>\r\n                        <select class=\"form-control col-2\" data-bind=\"value: getObservableListSize(), event: {change: function() { $parents[0].fillRecords(1); }}\" style=\"width:auto;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af72a27d860bd6426eea3c7e49891af19419bf411176", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af72a27d860bd6426eea3c7e49891af19419bf412360", async() => {
                WriteLiteral("20");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af72a27d860bd6426eea3c7e49891af19419bf413544", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af72a27d860bd6426eea3c7e49891af19419bf414728", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""col-6 order-1"">
                    <div class=""input-group justify-content-end"" data-bind=""if: getListNavigator().calculateTotalPages() > 1"">
                        <span class=""input-group-prepend"" data-bind=""css: {disabled: getCurrentList() === 1}""><a href=""#"" data-bind=""click: function(){ if (getCurrentList() > 1) { list(getCurrentList() - 1); } }""><span class=""input-group-text"">prev</span></a></span>
                        <span class=""input-group-append"" data-bind=""css: {disabled: getCurrentList() === getListNavigator().calculateTotalPages()}""><a href=""#"" data-bind=""click: function(){ if (getCurrentList() < getListNavigator().calculateTotalPages()) { list(getCurrentList() + 1); } }""><span class=""input-group-text"">next</span></a></span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""form-group"">
        <button cla");
            WriteLiteral(@"ss=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { displayProcessingActivity(); }"">Display Processing Activity</button>
        <button class=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { displayClearActivity(); }"">Display Clear Activity</button>
        <button class=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { clearListRecordsView(); }"">Clear Records</button>
    </div>
</section>
<div class=""modal fade"" id=""inputForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header form-group form-row"">
                <div class=""col-10 order-0"">
                    <h4 class=""modal-title d-flex justify-content-start"" id=""modalFormLabel"">
                        <span data-bind=""text: getEditMode() ? getEditModeCaption() : getNewModeCaption()""></span>
                    </h4>
            ");
            WriteLiteral(@"    </div>
                <div class=""col-2 order-1"">
                    <button type=""button"" class=""close d-flex justify-content-end"" data-dismiss=""modal"">
                        <span aria-hidden=""true"">×</span><span class=""sr-only"">close</span>
                    </button>
                </div>
            </div>
            <div class=""modal-body form-horizontal"" data-bind=""with: getObservableFormObject()"">
                <div class=""form-group form-group-sm"">
                    <span data-bind=""visible: $parents[0].getFormProcessing()"">
                        <i class=""fa fa-cog fa-spin fa-2x""></i>
                    </span>
                    <span data-bind=""if: $parents[0].getFormResultMessage().length > 0"" class=""alert"">
                        <span data-bind=""text: $parents[0].getFormResultMessage()""></span>
                    </span>
                </div>
                <section>
                    <div class=""form-group form-group-sm"">
                        <div");
            WriteLiteral(@" class=""col-3"">
                            <label class=""control-label"" for=""Name"">
                                <span>Name</span>
                            </label>
                            <input data-bind=""value: $parent.getEditMode() ? Name : Name"" id=""Name"" type=""text""
                                   maxlength=""50""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 8028, "\"", 8042, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" /><span class=""error""
                                                                                              data-bind=""validationMessage: Name""></span>
                        </div>
                        <div class=""col-9"">
                            <label class=""control-label"" for=""Description"">
                                <span>Description</span>
                            </label>
                            <input data-bind=""value: $parent.getEditMode() ? Description : Description"" id=""Description"" type=""text""
                                   maxlength=""200""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 8661, "\"", 8675, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" /><span class=""error""
                                                                                               data-bind=""validationMessage: Description""></span>
                        </div>
                    </div>
                    <div class=""clear-fix"">
                    </div>
                </section>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { displayFormProcessingActivity(); }"">Start Processing</button>
                <button class=""btn btn-default"" type=""button"" data-bind=""click: function(data,event) { displayFormClearActivity(); }"">Stop Processing</button>
                <button type=""button"" id=""btnCloseAddForm"" class=""btn btn-default"" data-dismiss=""modal"">
                    <span>close</span>
                </button>
                <button type=""button"" data-bind=""click: function(data,event) { getEditMode() ? update() : create");
            WriteLiteral("(); }\"\r\n                        id=\"btnAddEdit\" class=\"btn btn-primary\">\r\n                    <span>save</span>\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af72a27d860bd6426eea3c7e49891af19419bf421863", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">

        var units = new CRUDView({
            'uri': '/unit',
            'observer': new CRUDObserver({ 'contentType': new Unit({}), 'messages': new MessageRepository() })
        });

        units.getObserverObject().setListSource(units);

        $(function () {

            ko.validation.init({
                insertMessages: false,
                decorateElement: true,
                errorElementClass: 'error'
            });

            try {

                ko.applyBindings(units.getObserverObject());
            }
            catch (e) {

                console.log(e.message);
            }

            units.list(1);
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
