using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class CompanyController : AntiforgeryFormController<Company>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Company> GetRepository()
        {
            return new CompanyRepository((LocalAppContext)GetDBContext());
        }

        public IActionResult Index()
        {
            return View();
        }

        public override JsonResult Create([FromBody] Company contentObject)
        {
            contentObject.Enabled = true;
            return base.Create(contentObject);
        }

        public override JsonResult Update([FromBody] Company contentObject)
        {
            contentObject.Enabled = true;
            return base.Update(contentObject);
        }

        public override JsonResult Delete([FromBody] Company contentObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contentObject.Enabled = false;
                    contentObject = GetRepository().Update(contentObject);

                    return GetContentObjectResult(contentObject, null);
                }
            }
            catch
            {
                throw;
            }

            return GetObjectResultWithException(contentObject, "Exception", SharedLibrary.Core.Resources.Global.StandardMessages.AlertErr);
        }
    }
}