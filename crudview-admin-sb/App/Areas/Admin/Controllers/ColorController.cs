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
    [Authorize(Roles = "mngr_users,mngr_myaccount")]
    public class ColorController : AntiforgeryFormController<Color>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Color> GetRepository()
        {
            return new ColorRepository((LocalAppContext)GetDBContext());
        }

        public ColorController()
        {
            m_TargetRedirection = true;
        }
    }
}