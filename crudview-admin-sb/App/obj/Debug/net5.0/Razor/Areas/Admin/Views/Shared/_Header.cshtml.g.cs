#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb73365adc6479dd273348af0286daf8a0e66f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Header), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Header.cshtml")]
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
#nullable restore
#line 1 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb73365adc6479dd273348af0286daf8a0e66f27", @"/Areas/Admin/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- basic views -->
<script type=""text/html"" id=""request_progress"">
    <div class=""progress-bar"" role=""progressbar"" data-bind=""attr: { style: ('width: ' + RequestProgress()  + '%;'), 'aria-valuenow': (&quot; + RequestProgress() + &quot;) }"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""><span data-bind=""text: RequestProgress()""></span></div>
</script>

<script type=""text/html"" id=""results_processing"">
    <span class=""d-flex justify-content-end"">
        <i class=""fa fa-cog fa-spin"" data-bind=""visible: Processing()""></i>
    </span>
</script>
<script type=""text/html"" id=""results_messages"">
    <span class=""alert d-flex justify-content-start"" data-bind=""if: ResultMessage().length > 0"">
        <span data-bind=""text: ResultMessage""></span>
    </span>
</script>

<script type=""text/html"" id=""form_processing"">
    <span class=""d-flex justify-content-end"">
        <i class=""fa fa-cog fa-spin"" data-bind=""visible: FormProcessing()""></i>
    </span>
</script>
<script type=""text/html""");
            WriteLiteral(@" id=""form_messages"">
    <span class=""alert d-flex justify-content-start"" data-bind=""if: FormResultMessage().length > 0"">
        <span data-bind=""text: FormResultMessage""></span>
    </span>
</script>

<script type=""text/html"" id=""list_results_messages"">
    <span class=""d-flex justify-content-start"" data-bind=""if: ResultMessage().length > 0"">
        <span data-bind=""text: ResultMessage""></span>
    </span>
</script>
<script type=""text/html"" id=""list_error_messages"">
    <li class=""alert alert-danger""><span data-bind=""text: errField""></span> <span data-bind=""text: errMessage""></span></li>
</script>

<!-- NAVBAR -->
<nav class=""navbar navbar-expand-lg navbar-light bg-light"" role=""navigation"">
    <!-- MAIN NAVIGATION -->
    <div class=""navbar-brand"">
        <a");
            BeginWriteAttribute("href", " href=\"", 1922, "\"", 1957, 1);
#nullable restore
#line 45 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1929, Url.Action("index", "home"), 1929, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1977, "\"", 2016, 1);
#nullable restore
#line 46 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1983, Url.Content("~/images/logo.png"), 1983, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" alt=""Company"">
        </a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#main-nav"" aria-controls=""main-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
    </div>

");
#nullable restore
#line 53 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml"
      
        string[] rolesArray = null;
        string roles = Context.Session.GetString("roles");
        if (roles != null)
        {

            rolesArray = roles.Split(new char[] { ',' });
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 63 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Areas\Admin\Views\Shared\_Header.cshtml"
Write(Html.Raw(WindnTrees.Controls.Standard.Bootstrap.Navbar.NavigationComposer.composeFromJson(new string[] { ENV.ContentRootPath + "\\navigations\\navigation-admin.json", ENV.ContentRootPath + "\\navigations\\navigation-right.json" }, User.Identity.Name, rolesArray, null, null, "4.0")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!-- END MAIN NAVIGATION -->\r\n</nav>\r\n<!-- END NAVBAR -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebHostEnvironment ENV { get; private set; }
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
