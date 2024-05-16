using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.MyAccount.Controllers
{
    [Area("MyAccount")]
    [Authorize(Roles = "mngr_myaccount")]
    public class CategoryController : AntiforgeryFormController<Category>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Category> GetRepository()
        {
            return new CategoryRepository((LocalAppContext)GetDBContext());
        }

        public CategoryController()
        {
            m_TargetRedirection = true;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}