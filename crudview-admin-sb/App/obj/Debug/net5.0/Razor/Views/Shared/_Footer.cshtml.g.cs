#pragma checksum "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a0871bd2bad6734e5b4caea4e746b401b252def"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#nullable restore
#line 1 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0871bd2bad6734e5b4caea4e746b401b252def", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615b76ca350cdf68fac19737ed28cc93107e9a68", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- FOOTER -->
<footer id=""contentfooter"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4 order-0"">
                <!-- COLUMN 1 -->
                <div class=""row d-flex justify-content-start pl-3 pr-3"">
                    <img class=""clearfix""");
            BeginWriteAttribute("src", " src=\"", 431, "\"", 470, 1);
#nullable restore
#line 10 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 437, Url.Content("~/images/logo.png"), 437, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 471, "\"", 518, 1);
#nullable restore
#line 10 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 479, ApplicationSettings.Value.CompanyTitle, 479, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"d-block align-content-start\">");
#nullable restore
#line 11 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                        Write(ApplicationSettings.Value.BreifDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <address class=\"justify-content-start\">\r\n                    <div class=\"d-flex align-content-start\">");
#nullable restore
#line 14 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                       Write(ApplicationSettings.Value.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"d-flex align-content-start\">");
#nullable restore
#line 15 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                       Write(ApplicationSettings.Value.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"d-flex align-content-start\">");
#nullable restore
#line 16 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                       Write(ApplicationSettings.Value.AddressLine3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"d-flex align-content-start\">");
#nullable restore
#line 17 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                       Write(SharedLibrary.Core.Resources.Global.FormMessages.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <a");
            BeginWriteAttribute("href", " href=\"", 1155, "\"", 1208, 2);
            WriteAttributeValue("", 1162, "mailto:", 1162, 7, true);
#nullable restore
#line 17 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 1169, ApplicationSettings.Value.ContactEmail, 1169, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                                                                                                                         Write(ApplicationSettings.Value.ContactEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                    <div class=\"d-flex align-content-start\">");
#nullable restore
#line 18 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                       Write(SharedLibrary.Core.Resources.Global.FormMessages.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                                                                Write(ApplicationSettings.Value.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 18 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                                                                                                         Write(SharedLibrary.Core.Resources.Global.FormMessages.Cell);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                                                                                                                                                                 Write(ApplicationSettings.Value.ContactCell);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </address>\r\n                <!-- END COLUMN 1 -->\r\n            </div>\r\n            <div class=\"col-md-4 order-1\">\r\n                <!-- COLUMN 2 -->\r\n                <h3 class=\"footer-heading d-flex justify-content-start p-3\"");
            BeginWriteAttribute("title", " title=\"", 1762, "\"", 1832, 1);
#nullable restore
#line 24 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
WriteAttributeValue("", 1770, SharedLibrary.Core.Resources.Global.FormMessages.UsefulLinksD, 1770, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 25 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
               Write(SharedLibrary.Core.Resources.Global.FormMessages.UsefulLinks);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <div class=\"justify-content-start\">\r\n                    <div class=\"d-flex align-content-start pl-3 pr-3\">");
#nullable restore
#line 28 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                 Write(Html.ActionLink(Application.Core.Navigations.Navigation.Home, "index", "home", null, new { title = Application.Core.Navigations.Navigation.Home }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"d-flex align-content-start pl-3 pr-3\">");
#nullable restore
#line 29 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                 Write(Html.ActionLink(Application.Core.Navigations.Navigation.Products, "index", "product", null, new { title = Application.Core.Navigations.Navigation.Products }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"d-flex align-content-start pl-3 pr-3\">");
#nullable restore
#line 30 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                 Write(Html.ActionLink(Application.Core.Navigations.Navigation.News, "index", "news", null, new { title = Application.Core.Navigations.Navigation.News }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"d-flex align-content-start pl-3 pr-3\">");
#nullable restore
#line 31 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
                                                                 Write(Html.ActionLink(Application.Core.Navigations.Navigation.Contact, "index", "contactus", null, new { title = Application.Core.Navigations.Navigation.Contact }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <!-- END COLUMN 2 -->\r\n            </div>\r\n            <div class=\"col-md-4 order-2\">\r\n");
            WriteLiteral("                <!-- END COLUMN 3 -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- COPYRIGHT -->\r\n    <div class=\"text-center copyright\">\r\n        <span>");
#nullable restore
#line 62 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
         Write(ApplicationSettings.Value.CompanyTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 63 "D:\projects\softwares\windntrees\WindnTrees.Abstraction.Core.App\Views\Shared\_Footer.cshtml"
         Write(SharedLibrary.Core.Resources.Global.StandardMessages.AllRights);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <!-- END COPYRIGHT -->\r\n</footer>\r\n<!-- END FOOTER -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<Application.Core.Models.Configuration.ApplicationSettings> ApplicationSettings { get; private set; }
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