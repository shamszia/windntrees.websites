using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;

namespace Application.Core.Controllers
{
    [Authorize(Roles = "mngr_users")]
    public class ProductController : AntiforgeryFormController<Product>
    {
        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Product> GetRepository()
        {
            return new ProductRepository((LocalAppContext)GetDBContext());            
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            byte[] companyTitleBytes = null;
            string companyTitle = null;

            try
            {
                HttpContext.Session.TryGetValue("CompanyTitle", out companyTitleBytes);
                companyTitle = System.Text.UTF8Encoding.UTF8.GetString(companyTitleBytes);
            }
            catch { }

            ViewBag.CurrencySymbol = "Rs. ";

            byte[] currencySymbolBytes = null;
            string currencySymbol = null;

            try
            {
                HttpContext.Session.TryGetValue("CurrencySymbol", out currencySymbolBytes);
                currencySymbol = System.Text.UTF8Encoding.UTF8.GetString(currencySymbolBytes);
            }
            catch { }
            
            ViewBag.CurrencySymbol = currencySymbol != null ? currencySymbol : ViewBag.CurrencySymbol;

            return View();
        }

        [AllowAnonymous]
        public ActionResult Information(string id)
        {
            if (id != null)
            {
                ViewData.Add(new KeyValuePair<string, object>("ProductID", id));
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult Advertisements(string id)
        {
            if (id != null)
            {
                ViewData.Add(new KeyValuePair<string, object>("ProductID", id));
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult References(string id)
        {

            if (id != null)
            {
                ViewData.Add(new KeyValuePair<string, object>("ProductID", id));
            }

            return View();
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

        [AllowAnonymous]
        public JsonResult GetRandom()
        {
            try
            {
                var results = ((EntityRepository<Product>)GetRepository()).ListRandom(new SearchInput { total = 18 });
                return GetContentListResult(results, 0, null);
            }
            catch (Exception ex)
            {
                return GetListResultWithException(null, 0, "Exception", ex.Message);
            }
        }
    }
}