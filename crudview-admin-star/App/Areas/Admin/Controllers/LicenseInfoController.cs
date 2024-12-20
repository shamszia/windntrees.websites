﻿using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class LicenseInfoController : AntiforgeryFormController<LicenseInfo>
    {
        protected override DbContext GetDBContext()
        {
            return new ApplicationContext();
        }

        protected override CRUDLMRepository<LicenseInfo> GetRepository()
        {
            return new LicenseInfoRepository((ApplicationContext)GetDBContext());
        }

        public override JsonResult Update([FromBody] LicenseInfo contentObject)
        {
            var licenseInfo = ((ApplicationContext)GetDBContext()).LicenseInfo.Where(l => l.ProductId == contentObject.ProductId).SingleOrDefault();

            if (licenseInfo == null)
            {
                return base.Create(contentObject);
            }
            else
            {
                licenseInfo.Code = contentObject.Code;
                return base.Update(licenseInfo);
            }
        }
    }
}