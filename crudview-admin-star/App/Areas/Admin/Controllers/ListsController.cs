using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WindnTrees.Abstraction.Core.Controllers;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_myaccount,mngr_users")]
    public class ListsController : BasicController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}