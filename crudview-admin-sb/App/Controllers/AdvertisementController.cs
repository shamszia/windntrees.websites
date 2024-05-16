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
    [Authorize(Roles = "mngr_advertisements")]
    public class AdvertisementController : AntiforgeryFormController<Advertisement>
    {
        // GET: Advertisement
        public IActionResult Index()
        {
            return View();
        }

        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Advertisement> GetRepository()
        {
            return new AdvertisementRepository((LocalAppContext)GetDBContext());            
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

        [HttpGet]
        [AllowAnonymous]
        public JsonResult GetLatest(string count = "5")
        {
            try
            {   
                var results = ((EntityRepository<Advertisement>)GetRepository()).ListRandom(new SearchInput { total = int.Parse(count) });
                return GetContentListResult(results, 0, null);
            }
            catch (Exception ex)
            {
                return GetListResultWithException(null, 0, "Exception", ex.Message);
            }
        }

        [AllowAnonymous]
        public JsonResult GetLatestBy([FromBody] WebInput searchQuery)
        {
            try
            {
                var results = ((EntityRepository<Advertisement>)GetRepository()).ListRandom(searchQuery);
                return GetContentListResult(results, 0, null);
            }
            catch (Exception ex)
            {
                return GetListResultWithException(null, 0, "Exception", ex.Message);
            }
        }

        [AllowAnonymous]
        public JsonResult GetLatestNews(string count = "5")
        {
            try
            {
                List<SearchField> keywords = new List<SearchField>();
                keywords.Add(new SearchField { field = "News", value = "True" });

                var results = ((EntityRepository<Advertisement>)GetRepository()).ListRandom(new SearchInput { keywords = keywords, total = int.Parse(count) });
                return GetContentListResult(results, 0, null);
            }
            catch (Exception ex)
            {
                return GetListResultWithException(null, 0, "Exception", ex.Message);
            }
        }

        [AllowAnonymous]
        public JsonResult GetLatestNewsSingle()
        {
            try
            {
                var result = ((LocalAppContext)GetDBContext()).Advertisement.Where(l => l.News == true && l.Enabled == true).OrderByDescending(l => l.UpdateTime).FirstOrDefault();
                return GetContentObjectResult(result, null);
            }
            catch (Exception ex)
            {
                return GetObjectResultWithException(null, "Exception", ex.Message);
            }
        }
    }
}