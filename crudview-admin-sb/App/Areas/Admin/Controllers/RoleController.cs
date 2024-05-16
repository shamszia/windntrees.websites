using Application.Core.Data;
using Application.Core.Models.Configuration;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class RoleController : AntiforgeryFormController<IdentityRole>
    {   
        private IOptions<ApplicationSettings> _settingsOptions;
        private readonly ILogger<RoleController> _logger;

        public RoleController(ILogger<RoleController> logger,
            IOptions<ApplicationSettings> settings)
        {
            _logger = logger;
            _settingsOptions = settings;
        }

        public ActionResult Index()
        {
            return View();
        }

        protected override DbContext GetDBContext()
        {   
            return new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }

        protected override CRUDLMRepository<IdentityRole> GetRepository()
        {
            return new IdentityRoleRepository((ApplicationDbContext)GetDBContext());
        }
    }
}