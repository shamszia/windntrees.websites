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
    [Authorize(Roles = "mngr_configurations")]
    public class ConfigurationsController : AntiforgeryFormController<Configuration>
    {
        public IActionResult Index()
        {
            return View();
        }

        protected override DbContext GetDBContext()
        {
            return new ApplicationContext();
        }

        protected override CRUDLMRepository<Configuration> GetRepository()
        {
            return new ConfigurationsRepository((ApplicationContext)GetDBContext());
        }

        public override JsonResult Create(Configuration contentObject)
        {
            return base.Create(contentObject);
        }
    }
}
