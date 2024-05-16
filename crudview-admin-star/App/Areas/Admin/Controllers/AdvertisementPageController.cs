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
    public class AdvertisementPageController : AntiforgeryFormController<AdvertisementPage>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<AdvertisementPage> GetRepository()
        {
            return new AdvertisementPageRepository((LocalAppContext)GetDBContext());
        }
    }
}