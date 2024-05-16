#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Help\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a736257d0b2fc8029179abf289c9b94208abaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Help_Index), @"mvc.1.0.view", @"/Views/Help/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a736257d0b2fc8029179abf289c9b94208abaf", @"/Views/Help/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Views/_ViewImports.cshtml")]
    public class Views_Help_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Advertisement.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Help\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"
<!-- PAGE CONTENT -->
<div class=""page-content"">
    <div class=""container help-text"">
        <div name=""HTMLCode"">
            <section id=""htmlcode-section"">
                <div class=""form-group form-row"">
                    <div class=""col-4 order-0"">
                        <section data-bind=""with: getObserverObject()"">
                            <div class=""well"">
                                <section>
                                    <div class=""clearfix"">
                                        <span data-bind=""visible: getProcessing()""><i class=""fa fa-cog fa-spin fa-2x""></i></span>
                                        <span data-bind=""if: getResultMessage().length > 0"" class=""alert""><span data-bind=""text: getResultMessage()""></span></span>
                                        <div data-bind=""if: getErrors().length > 0"">
                                            <ul class=""errorlist"" data-bind=""foreach: { data: getObservableErrors(), as: 'error' }"">
                ");
            WriteLiteral(@"                                <li class=""alert""><span data-bind=""text: errField""></span> <span data-bind=""text: errMessage""></span></li>
                                            </ul>
                                        </div>
                                    </div>
                                </section>
                                <section>
                                    <ul class=""outer-items-list"">
                                        <li class=""outer-item-style"">
                                            <a data-toggle=""collapse"" href=""#list0"">
                                                <span><i class=""fa fa-chevron-down""></i></span>
                                                <span class=""h5"">List Records</span>
                                            </a>
                                            <ul id=""list0"" class=""inner-items-list"">
                                                <section data-bind=""foreach: {data: getRecords(), as: 'listReco");
            WriteLiteral(@"rdDetail'}"">
                                                    <li class=""inner-item-style"" data-bind=""if: (listRecordDetail !== null && listRecordDetail !== undefined)"">
                                                        <span data-bind=""if: getRecord() !== undefined"">
                                                            <span data-bind=""if: getDetail() !== undefined"">
                                                                <span data-bind=""if: getDetail().getSubListViews().length > 0"">
                                                                    <span data-bind=""with: getRecord()"">
                                                                        <a href=""#"" data-toggle=""collapse"" class=""green"" data-bind=""attr: {href: '#' + Uid}, click: function(data, event) { $parents[1].toggleDetail({'index':$index(), 'key': data.Uid, 'source': 'level1-recordid'}); }"" title=""select""><span data-bind=""text: Name(), attr: {title: Description()}""></span></a>
                          ");
            WriteLiteral(@"                                          </span>
                                                                </span>

                                                                <span data-bind=""if: getDetail().getSubListViews().length === 0"">
                                                                    <span data-bind=""with: getRecord()"">
                                                                        <a href=""#"" data-toggle=""collapse"" class=""green"" data-bind=""attr: {href: '#' + Uid}""><span data-bind=""text: Name(), attr: {title: Description()}""></span></a>
                                                                    </span>
                                                                </span>
                                                            </span>
                                                        </span>
                                                        <span data-bind=""if: getDetail() !== undefined"">
                                        ");
            WriteLiteral(@"                    <section data-bind=""with: getDetail()"">
                                                                <section data-bind=""with: getObserverObject()"">
                                                                    <ul class=""inner-items-list"" data-bind=""attr: {id: $parents[1].getRecord().Name()}"">
                                                                        <section data-bind=""foreach: { data: getRecords(), as: 'sublistRecordDetail' }"">
                                                                            <li class=""inner-item-style"">
                                                                                <span data-bind=""if: getRecord() !== undefined"">
                                                                                    <span data-bind=""if: getDetail() !== undefined"">
                                                                                        <span data-bind=""if: getDetail().getSubListViews().length > 0"">
                  ");
            WriteLiteral(@"                                                                          <span data-bind=""with: getRecord()"">
                                                                                                <a href=""#"" data-toggle=""collapse"" class=""green"" data-bind=""attr: {href: '#' + Uid}, click: function(data, event) { $parents[1].toggleDetail({'index':$index(), 'key': data.Uid, 'source': 'level1-recordid'}); $root.getObserverInterface().setSharedObject($parents[1]);}"" title=""select"">
                                                                                                    <span data-bind=""text: Heading(), attr: {title: SubHeading()}""></span>
                                                                                                </a>
                                                                                            </span>
                                                                                        </span>
                                                          ");
            WriteLiteral(@"                              <span data-bind=""if: getDetail().getSubListViews().length === 0"">
                                                                                            <span data-bind=""with: getRecord()"">
                                                                                                <a href=""#"" data-toggle=""collapse"" class=""green"" data-bind=""attr: {href: '#' + Uid}, click: function(data,event) { $parents[1].selectRecord({'record': $parents[0]}); $root.getObserverInterface().setSharedObject($parents[1]); }"" title=""select"">
                                                                                                    <span data-bind=""text: Heading(), attr: {title: SubHeading()}""></span>
                                                                                                </a>
                                                                                            </span>
                                                                                 ");
            WriteLiteral(@"       </span>
                                                                                    </span>
                                                                                </span>
                                                                            </li>
                                                                        </section>
                                                                        <section data-bind=""if: (getListNavigator() !== null && getListNavigator() !== undefined)"">
                                                                            <li class=""outer-item-style"">
                                                                                <div>
                                                                                    <ul data-bind=""if: getListNavigator().calculateTotalPages() > 1"" class=""searchlist"">
                                                                                        <li data-bind=""css: {disabled: getCurrentL");
            WriteLiteral(@"ist() === 1}""><a href=""#"" data-bind=""click: function(){ if (getCurrentList() > 1) { list(getCurrentList() - 1); } }""><span>prev</span></a></li>
                                                                                        <li data-bind=""css: {disabled: getCurrentList() === getListNavigator().calculateTotalPages()}""><a href=""#"" data-bind=""click: function(){ if ( getCurrentList() < getListNavigator().calculateTotalPages()) { list(getCurrentList() + 1); } }""><span>next</span></a></li>
                                                                                    </ul>
                                                                                </div>
                                                                                <div>
                                                                                    <ul data-bind=""if: getListNavigator().calculateTotalPages() > 1"" class=""searchlist"">
                                                                                        <");
            WriteLiteral(@"li data-bind=""css: {disabled: getCurrentList() === 1}""><a href=""#"" data-bind=""click: function(){ if (getCurrentList() > 1) { list(getCurrentList() - 1,'continue'); } }""><span>shorten</span></a></li>
                                                                                        <li data-bind=""css: {disabled: getCurrentList() === getListNavigator().calculateTotalPages()}""><a href=""#"" data-bind=""click: function(){ if ( getCurrentList() < getListNavigator().calculateTotalPages()) { list(getCurrentList() + 1, 'continue'); } }""><span>extend</span></a></li>
                                                                                    </ul>
                                                                                </div>
                                                                            </li>
                                                                        </section>
                                                                    </ul>
                                   ");
            WriteLiteral(@"                             </section>
                                                            </section>
                                                        </span>
                                                    </li>
                                                </section>
                                                <li class=""outer-item-style"" data-bind=""if: (getListNavigator() !== null && getListNavigator() !== undefined)"">
                                                    <div>
                                                        <ul data-bind=""if: getListNavigator().calculateTotalPages() > 1"" class=""searchlist"">
                                                            <li data-bind=""css: {disabled: getCurrentList() === 1}""><a href=""#"" data-bind=""click: function(){ if (getCurrentList() > 1) { list(getCurrentList() - 1); } }""><span>prev</span></a></li>
                                                            <li data-bind=""css: {disabled: getCurrentList() === getLis");
            WriteLiteral(@"tNavigator().calculateTotalPages()}""><a href=""#"" data-bind=""click: function(){ if ( getCurrentList() < getListNavigator().calculateTotalPages()) { list(getCurrentList() + 1); } }""><span>next</span></a></li>
                                                        </ul>
                                                    </div>
                                                    <div>
                                                        <ul data-bind=""if: getListNavigator().calculateTotalPages() > 1"" class=""searchlist"">
                                                            <li data-bind=""css: {disabled: getCurrentList() === 1}""><a href=""#"" data-bind=""click: function(){ if (getCurrentList() > 1) { list(getCurrentList() - 1, 'continue'); } }""><span>shorten</span></a></li>
                                                            <li data-bind=""css: {disabled: getCurrentList() === getListNavigator().calculateTotalPages()}""><a href=""#"" data-bind=""click: function(){ if ( getCurrentList() < getListNa");
            WriteLiteral(@"vigator().calculateTotalPages()) { list(getCurrentList() + 1, 'continue'); } }""><span>extend</span></a></li>
                                                        </ul>
                                                    </div>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>
                                </section>
                            </div>
                        </section>
                    </div>
                    <div class=""col-8 order-1"">
                        <section data-bind=""with: getObserverObject()"">
                            <section data-bind=""if: (getRecord() !== null && getRecord() !== undefined)"">
                                <section data-bind=""with: getRecord()"">
                                    <h3>Selected Role</h3>
                                    <p>Following fields display information about selecte");
            WriteLiteral(@"d role from outer list.</p>
                                    <div class=""form-group"">
                                        <div class=""input-group"">
                                            <input class=""form-control"" type=""text"" data-bind=""value: Name()"" readonly />
                                            <input class=""form-control"" type=""text"" data-bind=""value: Description()"" readonly />
                                        </div>
                                    </div>
                                </section>
                            </section>
                        </section>
                        <section data-bind=""with: getObserverObject()"">
                            <section data-bind=""with: getSharedObject()"">
                                <section data-bind=""if: (getRecord() !== null && getRecord() !== undefined)"">
                                    <section data-bind=""with: getRecord()"">
                                        <h3>Selected Action</h3>");
            WriteLiteral(@"
                                        <p>Following fields display information about selected action from inner list.</p>
                                        <div class=""form-group"">
                                            <div class=""input-group"">
                                                <input class=""form-control"" type=""text"" data-bind=""value: Heading()"" readonly />
                                                <input class=""form-control"" type=""text"" data-bind=""value: SubHeading()"" readonly />
                                            </div>
                                        </div>
                                    </section>
                                </section>
                            </section>
                        </section>
                    </div>
                </div>
            </section>
        </div>

    </div>
</div>
<!-- END PAGE CONTENT -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a736257d0b2fc8029179abf289c9b94208abaf22190", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a736257d0b2fc8029179abf289c9b94208abaf23377", async() => {
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
                WriteLiteral(@"

    <script type=""text/javascript"">
        /**
         * SearchList reference program implementation.
         *
         */
        function programCode() {
            var instance = this;

            instance.view0 = new SearchView({
                'uri': ""/product"",
                'observer': new SearchObserver({ 'contentType': new Product({}), 'messages': new MessageRepository() })
            });

            instance.view1 = new SearchView({
                'uri': ""/advertisement"",
                'observer': new SearchObserver({ 'contentType': new Advertisement({}), 'messages': new MessageRepository() })
            });

            instance.list = SearchList({ 'view': instance.view0, 'sublistviews': [instance.view1, instance.view1] });

            instance.getList = function () {
                return instance.list;
            };
        }

        $(function () {
            var program = new programCode();
            ko.applyBindings(program.getList());

  ");
                WriteLiteral("          program.getList().list(1);\r\n        });\r\n    </script>\r\n");
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
