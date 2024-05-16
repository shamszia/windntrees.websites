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
    public class ReferenceController : AntiforgeryFormController<Reference>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Reference> GetRepository()
        {
            return new ReferenceRepository((LocalAppContext)GetDBContext());            
        }

        [AllowAnonymous]
        public override JsonResult Read(string id)
        {
            return base.Read(id);
        }

        [AllowAnonymous]
        public override JsonResult List([FromBody]WebInput searchQuery)
        {
            return base.List(searchQuery);
        }
    }
}