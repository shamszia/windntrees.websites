using Application.Core.Models.Configuration;
using DataAccess.Core.Models;
using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System;
using System.Threading.Tasks;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_users")]
    public class ProductController : AntiforgeryFormController<Product>
    {
        private ApplicationSettings applicationSettings;

        public ProductController(IOptions<ApplicationSettings> options)
        {
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
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Product> GetRepository()
        {
            return new ProductRepository((LocalAppContext)GetDBContext());
        }

        protected override string GetUploadFolderPath()
        {
            return string.Format("{0}\\uploads\\product\\", Startup.ENV.WebRootPath);
        }

        public override Task<JsonResult> CreateFileContent([FromForm] Product contentObject)
        {
            //for model validation will be overriden by repository
            contentObject.Uid = Guid.NewGuid();
            ModelState.Remove("Uid");
            ModelState.SetModelValue("Uid", new ValueProviderResult(contentObject.Uid.ToString(), System.Threading.Thread.CurrentThread.CurrentCulture));

            StringValues ServiceValue = string.Empty;
            Request.Form.TryGetValue("Service", out ServiceValue);
            string Service = ServiceValue.ToString();

            if (Service != null)
            {
                if (Service.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Service = true;
                    if (ModelState.Remove("Service"))
                    {
                        ModelState.SetModelValue("Service", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            return base.CreateFileContent(contentObject);
        }

        public override Task<JsonResult> UpdateFileContent([FromForm] Product contentObject)
        {
            StringValues ServiceValue = string.Empty;
            Request.Form.TryGetValue("Service", out ServiceValue);
            string Service = ServiceValue.ToString();

            if (Service != null)
            {
                if (Service.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Service = true;
                    if (ModelState.Remove("Service"))
                    {
                        ModelState.SetModelValue("Service", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            return base.UpdateFileContent(contentObject);
        }

        protected override async Task<Product> SaveNewFileContent(Product contentObject, string fileName = null)
        {
            contentObject.Picture = fileName;

            //Empty task to avoid warning
            var awaitingTask = new Task(() =>
            { });
            await awaitingTask.ConfigureAwait(false);

            return GetRepository().Create(contentObject); ;
        }

        protected override async Task<Product> SaveExistingFileContent(Product contentObject, string fileName = null)
        {
            var repository = GetRepository();

            //Empty task to avoid warning
            var awaitingTask = new Task(() =>
            { });
            await awaitingTask.ConfigureAwait(false);

            var record = repository.Read(contentObject.Uid.ToString());
            record.Picture = fileName;
            return repository.Update(record);
        }
    }
}