#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d1fb8bd4f21e2b07b35a8108de3e0704920c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d1fb8bd4f21e2b07b35a8108de3e0704920c0f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/models/Product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 3 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
      Write(LocaleResources.Core.Views.Product.Index.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <script type=\"text/html\" id=\"listitem\">\r\n        <li");
                BeginWriteAttribute("class", " class=\"", 145, "\"", 153, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <a href=""#"" target=""_blank"" data-bind=""attr: { href: 'information/' + $data.Uid }""><img class=""img-responsive img-rounded"" data-bind=""attr: { src: PictureLink(), title: Name() }"" /></a>
            <div class=""detail"">
                <span data-bind=""text: BriefName(), attr: { title: Name() } "" class=""productname""></span>&nbsp;<sup><span data-bind=""text: ProductYear()""");
                BeginWriteAttribute("title", " title=\"", 543, "\"", 609, 1);
#nullable restore
#line 9 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
WriteAttributeValue("", 551, LocaleResources.Core.Contents.Product.Product.ProductYear, 551, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span></sup><br />\r\n                <span data-bind=\"text: Manufacturer()\"");
                BeginWriteAttribute("title", " title=\"", 686, "\"", 753, 1);
#nullable restore
#line 10 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
WriteAttributeValue("", 694, LocaleResources.Core.Contents.Product.Product.Manufacturer, 694, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>&nbsp;<span data-bind=\"text: Category()\"");
                BeginWriteAttribute("title", " title=\"", 802, "\"", 865, 1);
#nullable restore
#line 10 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
WriteAttributeValue("", 810, LocaleResources.Core.Contents.Product.Product.Category, 810, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>&nbsp;<span data-bind=\"text: Unit()\"");
                BeginWriteAttribute("title", " title=\"", 910, "\"", 969, 1);
#nullable restore
#line 10 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
WriteAttributeValue("", 918, LocaleResources.Core.Contents.Product.Product.Unit, 918, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></span>
            </div>
        </li>
    </script>

    <script type=""text/html"" id=""viewimage_product"">
        <table class=""table table-hover grid-style-0 grid-border-0"">
            <tr>
                <td colspan=""8""><h4><span data-bind=""text: $data.Name()""></span></h4></td>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 21 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.Version);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.Version()\"></span></td>\r\n                <td>");
#nullable restore
#line 23 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.ProductYear);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.ProductYear()\"></span></td>\r\n                <td>");
#nullable restore
#line 25 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.Code);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.Code()\"></span></td>\r\n                <td>");
#nullable restore
#line 27 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.LegalCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.LegalCode()\"></span></td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 31 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.Unit);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.Unit()\"></span></td>\r\n                <td>");
#nullable restore
#line 33 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.Color()\"></span></td>\r\n                <td>");
#nullable restore
#line 35 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</td>\r\n                <td><span data-bind=\"text: $data.Category()\"></span></td>\r\n                <td>");
#nullable restore
#line 37 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
               Write(LocaleResources.Core.Contents.Product.Product.Manufacturer);

#line default
#line hidden
#nullable disable
                WriteLiteral(@":</td>
                <td><span data-bind=""text: $data.Manufacturer()""></span></td>
            </tr>
            <tr>
                <td class=""scroll-y-100px"" colspan=""8"">
                    <span data-bind=""text: $data.Description()""></span>
                </td>
            </tr>
            <tr>
                <td colspan=""8"">
                    <img class=""img-fluid d-block m-auto"" data-bind=""attr: {src: $data.PictureLink() }""");
                BeginWriteAttribute("alt", " alt=\"", 2960, "\"", 2966, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("PagePath", async() => {
            }
            );
            WriteLiteral("\r\n<section id=\"products\">\r\n    <div class=\"container\">\r\n        <h2 class=\"d-flex align-content-start\">");
#nullable restore
#line 58 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
                                          Write(LocaleResources.Core.Views.Product.Index.Products);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        ");
#nullable restore
#line 59 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
   Write(Controls.Core.List.ListComposer.composeList("list_products", "", null, null, "products p-0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div style=\"display: none\">\r\n        ");
#nullable restore
#line 63 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
   Write(Controls.Core.Form.FormComposer.composeForm("__form_product_image", null, null, @SharedLibrary.Core.Resources.Global.FormMessages.ImageViewForm, "<div data-bind=\"template: {name: 'viewimage_product' }\"></div>", "view", null, null, null, false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 64 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
   Write(Controls.Core.List.ListComposer.composeStandardActions(null, "#", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 65 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Product\Index.cshtml"
   Write(Controls.Core.List.ListComposer.composeStandardListing(null, "__form_product_image", true, null, "Number, 'continue'", "CurrentList() + 1, 'continue'", "CurrentList() - 1, 'continue'", null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d1fb8bd4f21e2b07b35a8108de3e0704920c0f14691", async() => {
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

        var productsView = new CRUDView({
            'uri': '/product',
            'observer': new CRUDObserver({ 'contentType': new Product({}), 'messages': intialize(new MessageRepository()) })
        });

        productsView.getObserverObject().setListSource(productsView);

        $(function () {

            ko.applyBindings(productsView.getObserverObject());

            $('#__form_product_image').dialog({ autoOpen: false, width: 800, height: 700 });

            productsView.load(null, 'continue');
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
