using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace Application.Core.Controllers
{
    [Authorize(Roles = "mngr_users")]
    public class ProductFeatureController : AntiforgeryFormController<ProductFeature>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<ProductFeature> GetRepository()
        {
            return new ProductFeatureRepository((LocalAppContext)GetDBContext());            
        }

        [AllowAnonymous]
        public override JsonResult List(WebInput searchQuery)
        {
            return base.List(searchQuery);
        }
    }
}