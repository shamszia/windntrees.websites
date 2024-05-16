using Application.Core.Data;
using Application.Core.Models;
using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.Abstraction.Core.Results;
using WindnTrees.CRUDS.Repository.Core;
using WindnTrees.ICRUDS.Standard;
using Application.Core.Models.Configuration;
using Microsoft.Extensions.Options;

namespace Application.Core.Areas.MyAccount.Controllers
{
    [Area("MyAccount")]
    [Authorize(Roles = "mngr_myaccount")]
    public class HomeController : AntiforgeryFormController<Product>
    {
        private UserManager<ApplicationUser> ManagerUser { get; set; }
        private ApplicationSettings applicationSettings { get; set; }

        public HomeController(UserManager<ApplicationUser> userManager, IOptions<ApplicationSettings> options)
        {
            ManagerUser = userManager;
            applicationSettings = options.Value;
        }

        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Product> GetRepository()
        {
            return new ProductRepository((LocalAppContext)GetDBContext());
        }

        public IActionResult Index()
        {
            ViewData.Add("CurrencySymbol", applicationSettings.CurrencySymbol);
            return View();
        }

        public IActionResult MyProfile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult UpdateProfile([FromBody] UserEditModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var repository = new ApplicationUserRepository(new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>()));
                    var contextUser = repository.GetByName(User.Identity.Name);
                    if (contextUser != null)
                    {
                        contextUser.FirstName = model.FirstName;
                        contextUser.LastName = model.LastName;
                        contextUser.Sex = model.Sex;
                        contextUser.Title = model.Title;
                        contextUser.ImageFile = model.ImageFile;
                        contextUser.Email = model.Email;

                        repository.Update(contextUser);
                    }

                    return GetObjectResult(model, null);
                }

                List<ErrorObject> errors = new List<ErrorObject>();

                var modelStateErrors = this.ModelState.Keys.SelectMany(key => this.ModelState[key].Errors);
                foreach (var modelStateError in modelStateErrors)
                {
                    errors.Add(new ErrorObject("exception", modelStateError.ErrorMessage));
                }

                return GetObjectResult(model, errors);
            }
            catch (Exception ex)
            {
                return GetObjectResultWithException(null, "", ex.Message);
            }
        }

        public JsonResult GetProfile()
        {
            try
            {
                Task<ApplicationUser> userTask = ManagerUser.FindByNameAsync(User.Identity.Name);
                while (!userTask.IsCompleted)
                {
                    System.Threading.Thread.Sleep(10);
                }
                ApplicationUser user = userTask.Result;

                var profileResponseObject = new
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Sex = user.Sex,
                    Title = user.Title,
                    ImageFile = user.ImageFile,
                    Package = user.Package,
                    Email = user.Email
                };

                return GetObjectResult(profileResponseObject, null);
            }
            catch (Exception ex)
            {
                return GetObjectResultWithException(null, "", ex.Message);
            }
        }

        public IActionResult GetDashboardReport([FromBody] WindnTrees.ICRUDS.Standard.WebInput webInput)
        {
            var repository = new ProductRepository(new LocalAppContext());
            var report = repository.GetDashboardReport(new WindnTrees.ICRUDS.Standard.SearchInput(webInput));

            return Json(new WindnTrees.Abstraction.Core.Results.ResultObject<DashboardReport>(report));
        }

        public IActionResult GetMonthlyChartSummary([FromBody] WindnTrees.ICRUDS.Standard.WebInput webInput)
        {
            /*
                Following monthly chart summary data for example and integration only.
                Modify repository method 'GetMonthlyChartSummary' to load data from database.
            */
            var repository = new ProductRepository(new LocalAppContext());
            var reports = repository.GetMonthlyChartSummary(new WindnTrees.ICRUDS.Standard.SearchInput(webInput));

            return Json(new WindnTrees.Abstraction.Core.Results.ResultList<Object>(reports.Cast<object>().ToList(), reports.Count));
        }
    }
}