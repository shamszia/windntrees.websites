using Application.Core.Data;
using Application.Core.Models;
using Application.Core.Models.AccountViewModels;
using Application.Core.Services;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Application.Core.Models.Configuration;
using DataAccess.Core.Models;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class UsersController : AntiforgeryFormController<ApplicationUser>
    {
        private UserManager<ApplicationUser> ManagerUser { get; set; }
        private RoleManager<IdentityRole> ManagerRole { get; set; }
        private SignInManager<ApplicationUser> ManagerSignIn { get; set; }
        private IEmailSender EmailSender { get; set; }
        private ILogger<UsersController> _logger { get; set; }
        private ApplicationSettings applicationSettings { get; set; }
        private IOptions<ApplicationSettings> _settingsOptions;

        public UsersController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<UsersController> logger,
            IOptions<ApplicationSettings> options)
        {
            ManagerUser = userManager;
            ManagerRole = roleManager;
            ManagerSignIn = signInManager;
            EmailSender = emailSender;
            _logger = logger;
            _settingsOptions = options;
            applicationSettings = options.Value;

            FilesExtensionsLimit = applicationSettings.AllowedExtensions;
            FileLengthLimit = int.Parse(applicationSettings.MaxFileSizeInKB);
        }

        public IActionResult Index()
        {
            return View();
        }

        protected override DbContext GetDBContext()
        {
            return new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
        }

        protected override string GetUploadFolderPath()
        {
            return System.IO.Path.Combine(new string[] { Startup.ENV.WebRootPath, "uploads", "users" });
            //return string.Format("{0}\\uploads\\users\\", Startup.ENV.WebRootPath);
        }

        protected override CRUDLMRepository<ApplicationUser> GetRepository()
        {
            return new ApplicationUserRepository((ApplicationDbContext)GetDBContext());
        }

        public override JsonResult Create([FromBody] ApplicationUser model)
        {
            if (string.IsNullOrEmpty(model.Password) || string.IsNullOrEmpty(model.ConfirmPassword))
            {
                return GetModelStateResultObject(model, ModelState);
            }
            else
            {
                if (model.Password.Equals(model.ConfirmPassword))
                {
                    if (ModelState.IsValid)
                    {
                        var existingUser = (new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>())).Users.Where(l => l.UserName == model.UserName).SingleOrDefault();
                        if (existingUser != null)
                        {
                            ModelState.AddModelError("User", SharedLibrary.Core.Resources.Global.FormMessages.RecordExists);
                        }
                        else
                        {
                            model.CreationDate = DateTime.UtcNow;
                            model.ApprovedBy = User.Identity.Name;

                            List<IdentityUserRole<string>> roles = new List<IdentityUserRole<string>>(model.Roles.ToArray<IdentityUserRole<string>>());

                            model.Roles.Clear();

                            //passwordhash will be treated as string password here.
                            var result = ManagerUser.CreateAsync(model, model.Password).Result;

                            if (result.Succeeded)
                            {
                                _logger.LogInformation("User created a new account with password.");

                                var RepositoryUserRoles = new IdentityUserRoleRepository(new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>()));
                                RepositoryUserRoles.AddUserRoles(model.Id, roles.Select(l => l.RoleId).ToArray<string>());
                                
                                var code = ManagerUser.GenerateEmailConfirmationTokenAsync(model).Result;
                                var callbackUrl = Url.EmailConfirmationLink(model.Id, code, Request.Scheme);

                                try
                                {
                                    if (!string.IsNullOrEmpty(applicationSettings.EmailUserPassword))
                                    {
                                        //do not send email if email password is not set.

                                        //string emailMessage = Util.RenderViewToString(this, "~/views/shared/emailtemplates/newaccount.cshtml", accountModel);
                                        EmailSender.SendEmailConfirmationAsync(model.Email, callbackUrl).RunSynchronously();
                                    }
                                }
                                catch
                                {
                                    throw;
                                }

                                try
                                {
                                    ActivityHistoryRepository attendanceRepository = new ActivityHistoryRepository(new LocalAppContext());
                                    attendanceRepository.Create(new ActivityHistory
                                    {
                                        Uid = Guid.NewGuid(),
                                        ActivityTime = DateTime.UtcNow,
                                        Activity = "new admin-registration",
                                        Request = HttpContext.Request.Path,
                                        UserId = model.Id,
                                        Ipaddress = string.Format("{0}:{1}", HttpContext.Connection.RemoteIpAddress, HttpContext.Connection.RemotePort)
                                    });
                                }
                                catch
                                {
                                    throw;
                                }

                                _logger.LogInformation("User created a new account with password.");

                                model.PasswordHash = string.Empty;
                                model.SecurityStamp = string.Empty;

                                //return user object after conversion
                                return GetContentObjectResult(model, null);
                            }
                            else
                            {   
                                foreach(var error in result.Errors)
                                {
                                    ModelState.AddModelError(error.Code, error.Description);
                                }
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Password", string.Format(SharedLibrary.Core.Resources.Global.ValidationMessages.Compare, "Password", "ConfirmPassword"));
                    }
                }
            }

            return GetModelStateResultObject(model, ModelState);
        }

        public override JsonResult Update([FromBody] ApplicationUser model)
        {
            if (ModelState.IsValid)
            {
                List<IdentityUserRole<string>> roles = new List<IdentityUserRole<string>>(model.Roles.ToArray<IdentityUserRole<string>>());
                //remove roles before updating user model.
                model.Roles.Clear();

                var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
                var user = context.Users.Where(l => l.UserName == model.UserName).SingleOrDefault();
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Sex = model.Sex;
                    user.Title = model.Title;
                    user.Email = model.Email;
                    user.Package = model.Package;
                    user.ExpiryDate = model.ExpiryDate;
                    user.IsApproved = model.IsApproved;
                    user.EmailConfirmed = model.EmailConfirmed;
                }

                if (context.SaveChanges() > 0)
                {
                    //var user1 = ManagerUser.FindByNameAsync(model.UserName).Result;
                    var RepositoryUserRoles = new IdentityUserRoleRepository(new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>()));

                    RepositoryUserRoles.RemoveUserRoles(user.Id);
                    RepositoryUserRoles.AddUserRoles(user.Id, roles.Select(l => l.RoleId).ToArray<string>());
                }

                //update model for updated response with roles.
                model.Roles = roles;
                return GetContentObjectResult(model, null);
            }

            return GetObjectResultWithException(model, "Exception", SharedLibrary.Core.Resources.Global.StandardMessages.AlertErr);
        }

        public override JsonResult Delete([FromBody] ApplicationUser model)
        {
            if (model.Email.Equals(applicationSettings.AdminEmail, StringComparison.OrdinalIgnoreCase))
            {
                return GetObjectResultWithException(model, "Exception", SharedLibrary.Core.Resources.Global.StandardMessages.AlertErr);
            }
            else
            {
                var user = ManagerUser.FindByNameAsync(model.UserName).Result;
                var result = ManagerUser.DeleteAsync(user).Result;

                if (result.Succeeded)
                {
                    model.PasswordHash = string.Empty;
                    model.SecurityStamp = string.Empty;

                    return GetContentObjectResult(model, null);
                }
                else
                {
                    return GetObjectResultWithException(model, "", SharedLibrary.Core.Resources.Global.ValidationMessages.DeletionFailure);
                }
            }
        }

        protected override bool SaveFileRecord(object recordId, string fileName)
        {
            try
            {
                var repository = GetRepository();
                var record = repository.Read(recordId);
                record.ImageFile = fileName;
                repository.Update(record);

                return true;
            }
            catch
            {
                throw;
            }
        }

        public JsonResult ChangePassword([FromBody] ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ApplicationUser user = ManagerUser.FindByNameAsync(User.Identity.Name).Result;

                    if (user != null)
                    {
                        ManagerUser.RemovePasswordAsync(user);
                        ManagerUser.AddPasswordAsync(user, model.Password);

                        return GetObjectResult(new { User = User.Identity.Name, Result = true }, null);
                    }
                }
                catch
                {
                    throw;
                }

                model.Password = string.Empty;
                model.ConfirmPassword = string.Empty;

                return GetObjectResultWithException(model, "", SharedLibrary.Core.Resources.Global.StandardMessages.AlertErr);
            }

            model.Password = string.Empty;
            model.ConfirmPassword = string.Empty;

            return GetModelStateResultObject(model, ModelState);
        }

        public JsonResult GetPackagesList()
        {
            var packages = new string[] { "Package1", "Package2", "Package3" };
            return GetListResult(new List<object>(packages));
        }

        public JsonResult GetAvailableRoles()
        {
            var roles = ManagerRole.Roles.ToList();
            return GetListResult(roles.ToList<Object>());
        }
    }
}
