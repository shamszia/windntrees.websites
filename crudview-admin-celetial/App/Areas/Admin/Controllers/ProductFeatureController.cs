using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class ProductFeatureController : AntiforgeryFormController<ProductFeature>
    {
        public ActionResult Index(string id)
        {
            if (id != null)
            {
                ViewData.Add(new KeyValuePair<string, object>("ProductID", id));
            }
            return View();
        }

        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<ProductFeature> GetRepository()
        {
            return new ProductFeatureRepository((LocalAppContext)GetDBContext());
        }
    }
}