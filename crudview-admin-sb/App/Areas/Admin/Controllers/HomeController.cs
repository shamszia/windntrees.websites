using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class HomeController : AntiforgeryFormController<ActivityHistory>
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<ActivityHistory> GetRepository()
        {
            return new ActivityHistoryRepository((LocalAppContext)GetDBContext());            
        }
    }
}
