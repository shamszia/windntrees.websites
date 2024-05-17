using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.Abstraction.Core.Results;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace Application.Core.Controllers
{
    public class ColorEmptyController : EmptyCRUDLController<Color>
    {
        public ColorEmptyController()
        {
            m_TargetRedirection = true;
        }

        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMEmptyRepository<Color> GetRepository()
        {
            return new ColorEmptyRepository((LocalAppContext)GetDBContext());
        }

        //controller target (CRUDMethod)

        public JsonResult CreateCRUD()
        {
            return base.Create();
        }

        public JsonResult ReadCRUD()
        {
            return base.Read();
        }

        public JsonResult UpdateCRUD()
        {
            return base.Update();
        }

        public JsonResult DeleteCRUD()
        {
            return base.Delete();
        }

        public JsonResult ListCRUD()
        {
            return base.List();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
