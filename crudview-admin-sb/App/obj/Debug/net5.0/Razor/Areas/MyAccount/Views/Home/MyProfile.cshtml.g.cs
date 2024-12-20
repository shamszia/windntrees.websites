#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdec307f8e7c71575b24d8f26f54742eb76db934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MyAccount_Views_Home_MyProfile), @"mvc.1.0.view", @"/Areas/MyAccount/Views/Home/MyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdec307f8e7c71575b24d8f26f54742eb76db934", @"/Areas/MyAccount/Views/Home/MyProfile.cshtml")]
    public class Areas_MyAccount_Views_Home_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/User.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/FileUploadHandler.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DateTimeHandlers.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 7 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
      Write(LocaleResources.Core.Views.UserProfile.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

    <script type=""text/html"" id=""uploadcontent"">
        <img class=""img-fluid d-block m-auto"" data-bind=""attr:{src: $data.gridurl() }"" />
        <div class=""form-group"">
            <div class=""col-12"">
                <label class=""control-label"" for=""upload"">
                    ");
#nullable restore
#line 14 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
               Write(SharedLibrary.Core.Resources.Global.FormMessages.UploadImage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
                <form>
                    <input id=""uploadType"" name=""uploadType"" type=""hidden"" value=""users"" />
                    <input id=""updateField"" name=""updateField"" type=""hidden"" value=""ImageFile"" />
                    <input id=""upload"" name=""upload"" type=""file"" data-bind=""fileUpload: { property: ImageFile }"" />
                </form>
            </div>
        </div>
        <div class=""clear-fix"">
        </div>
    </script>

    <script type=""text/html"" id=""viewcontent"">
        <img class=""img-fluid d-block m-auto"" data-bind=""attr:{src: $data.gridurl() }"" />
    </script>
");
            }
            );
            WriteLiteral("\r\n<div class=\"page-content\">\r\n    <div class=\"card container\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"d-flex align-content-start\">");
#nullable restore
#line 35 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                                              Write(LocaleResources.Core.Views.UserProfile.Index.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p class=\"d-flex align-content-start\">");
#nullable restore
#line 36 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                                             Write(LocaleResources.Core.Views.UserProfile.Index.PageD);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div class=""row"">
                <div class=""col order-0"">
                    <div data-bind=""template: {name: 'results_messages' }""></div>
                </div>
                <div class=""col order-1"">
                    <div data-bind=""template: {name: 'results_processing' }""></div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"" data-bind='if: Errors().length > 0'>
                    <ul class='errorlist' data-bind=""template: {name: 'list_error_messages' , foreach: Errors}""></ul>
                </div>
            </div>
        </div>
        <div class=""card-body"">
            <form data-bind=""with: getObservableInputObject()"">
                <div class=""row"">
                    <div class=""col-6 order-0"">
                        <div class=""form-group form-group-md"">
                            <input data-bind=""value: FirstName"" id=""FirstName"" type=""text"" maxlength=""50""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2450, "\"", 2517, 1);
#nullable restore
#line 56 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 2464, LocaleResources.Core.Contents.Account.User.FirstName, 2464, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2518, "\"", 2579, 1);
#nullable restore
#line 56 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 2526, LocaleResources.Core.Contents.Account.User.FirstName, 2526, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""form-control"" /><span class=""error"" data-bind=""validationMessage: FirstName""></span>
                        </div>
                        <div class=""form-group form-group-md"">
                            <input data-bind=""value: LastName"" id=""LastName"" type=""text"" maxlength=""100""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2910, "\"", 2976, 1);
#nullable restore
#line 60 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 2924, LocaleResources.Core.Contents.Account.User.LastName, 2924, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2977, "\"", 3037, 1);
#nullable restore
#line 60 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 2985, LocaleResources.Core.Contents.Account.User.LastName, 2985, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""form-control"" /><span class=""error"" data-bind=""validationMessage: LastName""></span>
                        </div>
                        <div class=""form-group form-group-md"">
                            <input data-bind=""value: Title"" id=""Title"" type=""text"" maxlength=""50""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3360, "\"", 3423, 1);
#nullable restore
#line 64 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 3374, LocaleResources.Core.Contents.Account.User.Title, 3374, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3424, "\"", 3481, 1);
#nullable restore
#line 64 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 3432, LocaleResources.Core.Contents.Account.User.Title, 3432, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""form-control"" /><span class=""error"" data-bind=""validationMessage: Title""></span>
                        </div>
                        <div class=""form-group form-group-md"">
                            <select data-bind=""options: $root.Genders, optionsText: 'key', optionsValue: 'val', value: Sex, optionsCaption: '");
#nullable restore
#line 68 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                                                                                                                                        Write(LocaleResources.Core.Contents.Account.User.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\"");
            BeginWriteAttribute("title", " title=\"", 3897, "\"", 3955, 1);
#nullable restore
#line 68 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 3905, LocaleResources.Core.Contents.Account.User.Gender, 3905, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                    id=""Sex"" class=""form-control""></select><span class=""error"" data-bind=""validationMessage: Sex""></span>
                        </div>
                        <div class=""form-group form-group-md"">
                            <input data-bind=""value: Email"" id=""Email"" type=""text"" maxlength=""150""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4291, "\"", 4354, 1);
#nullable restore
#line 72 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 4305, LocaleResources.Core.Contents.Account.User.Email, 4305, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4355, "\"", 4412, 1);
#nullable restore
#line 72 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
WriteAttributeValue("", 4363, LocaleResources.Core.Contents.Account.User.Email, 4363, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""form-control"" /><span class=""error"" data-bind=""validationMessage: Email""></span>
                        </div>
                    </div>
                    <div class=""col-6 order-1"">
                        <div style=""text-align:center"">
                            <a href=""#"" data-toggle=""modal"" data-target=""#thirdForm"">
                                <img class=""img-fluid img-rounded d-block m-auto"" data-bind=""attr:{src: gridurl}"" style=""width: 240px;"" />
                            </a>
                            <span style=""clear:both""></span>
                            <a class=""green"" href=""#"" data-toggle=""modal"" data-target=""#secondForm"">[");
#nullable restore
#line 82 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                                                                                                Write(SharedLibrary.Core.Resources.Global.FormMessages.UploadImage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]</a>
                        </div>
                    </div>
                </div>
            </form>
        </div>
        <div class=""card-footer"">
            <div class=""row"">
                <div class=""col-12"">
                    <button data-bind=""click: function(data, event) { update({ content:  getObservableInputObject(), target: 'updateprofile', TimeFields: [ 'CreationDate', 'ExpiryDate' ], code: '' }); }"" id=""updateprofile"" type=""button"" class=""btn btn-primary pull-left"">
                        ");
#nullable restore
#line 92 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                   Write(SharedLibrary.Core.Resources.Global.FormMessages.Update);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 100 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
Write(Controls.Core.Form.FormComposer.composeForm("secondForm", null, null, @SharedLibrary.Core.Resources.Global.FormMessages.ImageViewForm, "<div data-bind=\"template: {name: 'uploadcontent' }\"></div>", "upload"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 102 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
Write(Controls.Core.Form.FormComposer.composeForm("thirdForm", null, null, @SharedLibrary.Core.Resources.Global.FormMessages.ImageViewForm, "<div data-bind=\"template: {name: 'viewcontent' }\"></div>", "view"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdec307f8e7c71575b24d8f26f54742eb76db93416775", async() => {
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdec307f8e7c71575b24d8f26f54742eb76db93417966", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdec307f8e7c71575b24d8f26f54742eb76db93419153", async() => {
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
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {
            var view = new EditView({
                'uri': '/myaccount/home',
                'observer': new ObjectObserver({ 'contentType': new User({}), 'messages': intialize(new MessageRepository()) })
            });

            view.getObserverObject().Genders = ko.observableArray([
                new OptionItem(reformUniCodeString('");
#nullable restore
#line 120 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                                               Write(SharedLibrary.Core.Resources.Global.FormMessages.Male);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'), \'m\'),\r\n                new OptionItem(reformUniCodeString(\'");
#nullable restore
#line 121 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\MyAccount\Views\Home\MyProfile.cshtml"
                                               Write(SharedLibrary.Core.Resources.Global.FormMessages.Female);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'), 'f')
            ]);

            try {

                ko.applyBindings(view.getObserverObject());

            } catch (e) {

                console.log(e.message);
            }

            view.read({ 'target': 'getprofile' });
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
