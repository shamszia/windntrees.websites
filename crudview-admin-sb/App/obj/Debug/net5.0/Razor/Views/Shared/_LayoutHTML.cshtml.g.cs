#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_LayoutHTML.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8befc699629d3458ec245402a765de4943f7cb57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutHTML), @"mvc.1.0.view", @"/Views/Shared/_LayoutHTML.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8befc699629d3458ec245402a765de4943f7cb57", @"/Views/Shared/_LayoutHTML.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutHTML : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8befc699629d3458ec245402a765de4943f7cb574831", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 232, "\"", 242, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 269, "\"", 279, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""icon"" href=""../../favicon.ico"">
    <title>Fixed Top Navbar Example for Bootstrap</title>
    <!-- Bootstrap core CSS -->
    <link href=""../../dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Custom styles for this template -->
    <link href=""navbar-fixed-top.css"" rel=""stylesheet"">
    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src=""../../assets/js/ie8-responsive-file-warning.js""></script><![endif]-->
    <script src=""../../assets/js/ie-emulation-modes-warning.js""></script>
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
<script src=""https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js""></script>
<script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
<![endif]-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8befc699629d3458ec245402a765de4943f7cb577223", async() => {
                WriteLiteral(@"
    <!-- Fixed navbar -->
    <nav class=""navbar navbar-default navbar-fixed-top"" role=""navigation"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span> <span class=""icon-bar""></span><span
                        class=""icon-bar""></span><span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""#"">Project name</a>
            </div>
            <div class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav"">
                    <li class=""active""><a href=""#"">Home</a></li>
                    <li><a href=""#about"">About</a></li>
                    <li><a href=""#contact"">Contact</a></li>
                    <li class=""dropdown""><a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">Dropdown
                        <span ");
                WriteLiteral(@"class=""caret""></span></a>
                        <ul class=""dropdown-menu"" role=""menu"">
                            <li><a href=""#"">Action</a></li>
                            <li><a href=""#"">Another action</a></li>
                            <li><a href=""#"">Something else here</a></li>
                            <li class=""divider""></li>
                            <li class=""dropdown-header"">Nav header</li>
                            <li><a href=""#"">Separated link</a></li>
                            <li><a href=""#"">One more separated link</a></li>
                        </ul>
                    </li>
                </ul>
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""../navbar/"">Default</a></li>
                    <li><a href=""../navbar-static-top/"">Static top</a></li>
                    <li class=""active""><a href=""./"">Fixed top</a></li>
                </ul>
            </div>
            <!--/.nav-collapse -->
        </div>
    </na");
                WriteLiteral(@"v>
    <div class=""container"">
        <!-- Main component for a primary marketing message or call to action -->
        <div class=""jumbotron"">
            <h1>
                Navbar example</h1>
            <p>
                This example is a quick exercise to illustrate how the default, static and fixed
                to top navbar work. It includes the responsive CSS and HTML, so it also adapts to
                your viewport and device.</p>
            <p>
                To see the difference between static and fixed top navbars, just scroll.</p>
            <p>
                <a class=""btn btn-lg btn-primary"" href=""../../components/#navbar"" role=""button"">View
                    navbar docs &raquo;</a>
            </p>
        </div>
    </div>
    <!-- /container -->
    <!-- Bootstrap core JavaScript
================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src=""https://ajax.googleapis.com/aja");
                WriteLiteral("x/libs/jquery/1.11.1/jquery.min.js\"></script>\r\n    <script src=\"../../dist/js/bootstrap.min.js\"></script>\r\n    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->\r\n    <script src=\"../../assets/js/ie10-viewport-bug-workaround.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
