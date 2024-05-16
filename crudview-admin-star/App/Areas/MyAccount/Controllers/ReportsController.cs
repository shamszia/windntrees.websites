using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WindnTrees.Abstraction.Core.Controllers;

namespace Application.Core.Areas.MyAccount.Controllers
{
    [Area("MyAccount")]
    [Authorize(Roles = "mngr_myaccount")]
    public class ReportsController : BasicController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}