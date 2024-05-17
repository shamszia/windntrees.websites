using Microsoft.AspNetCore.Mvc;
using WindnTrees.Abstraction.Core.Controllers;

namespace Application.Core.Areas.MyAccount.Controllers
{
    [Area("MyAccount")]
    public class HelpController : BasicController
    {
        // GET: MyAccount/Help
        public IActionResult Index()
        {
            return Redirect("~/help/index");
        }

        public IActionResult About()
        {
            return Redirect("~/help/about");
        }
    }
}