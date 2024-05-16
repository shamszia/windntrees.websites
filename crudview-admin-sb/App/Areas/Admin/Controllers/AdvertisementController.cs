using DataAccess.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Application.Core.Models.Configuration;
using Microsoft.Extensions.Options;
using DataAccess.Core.Models;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.CRUDS.Repository.Core;
using System.Threading.Tasks;

namespace Application.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "mngr_advertisements")]
    public class AdvertisementController : AntiforgeryFormController<Advertisement>
    {
        private ApplicationSettings applicationSettings;

        public AdvertisementController(IOptions<ApplicationSettings> options)
        {
            applicationSettings = options.Value;

            FilesExtensionsLimit = applicationSettings.AllowedExtensions;
            FileLengthLimit = int.Parse(applicationSettings.MaxFileSizeInKB);
        }

        // GET: Admin/Advertisement
        public IActionResult Index(string id)
        {
            if (id != null)
            {
                ViewData.Add(new KeyValuePair<string, object>("ReferenceId", id));
            }

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

        protected override string GetUploadFolderPath()
        {
            return string.Format("{0}\\uploads\\image\\", Startup.ENV.WebRootPath);
        }

        public override JsonResult Create(
            [Bind(include: new string[] {"ReferenceId","Heading","SubHeading","Detail","Picture","Video","Link1","Link2","Source","Page","Location","SortOrder","News","Enabled" })]
            [FromBody] Advertisement contentObject)
        {
            contentObject.RecordTime = DateTime.UtcNow;
            contentObject.UpdateTime = DateTime.UtcNow;

            return base.Create(contentObject);
        }

        public override JsonResult Update(
            [Bind(include: new string[] { "Uid", "ReferenceId", "RecordTime", "UpdateTime", "Heading","SubHeading","Detail","Picture","Video","Link1","Link2","Source","Page","Location","SortOrder","News","Enabled", "RowVersion" })]
            [FromBody] Advertisement contentObject)
        {
            contentObject.UpdateTime = DateTime.UtcNow;
            return base.Update(contentObject);
        }

        protected override bool SaveFileRecord(object recordId, string fileName)
        {
            try
            {
                var repository = GetRepository();
                var record = repository.Read(recordId);
                
                StringValues uploadTypeStructure = string.Empty;
                Request.Form.TryGetValue("uploadType", out uploadTypeStructure);

                var uploadType = uploadTypeStructure.ToString();
                if (!string.IsNullOrEmpty(uploadType))
                {
                    if (uploadType.Equals("image", StringComparison.OrdinalIgnoreCase))
                    {
                        record.Picture = fileName;
                    }
                    else if (uploadType.Equals("video", StringComparison.OrdinalIgnoreCase))
                    {
                        record.Video = fileName;
                    }
                }
                else
                {
                    record.Picture = fileName;
                }

                //extend repository with direct query to update required fields.
                repository.Update(record);

                return true;
            }
            catch
            {
                throw;
            }
        }

        public override Task<JsonResult> CreateFileContent(
            [Bind(include: new string[] { "ReferenceId", "Heading","SubHeading","Detail","Picture","Video","Link1","Link2","Source","Page","Location","SortOrder","News","Enabled" })]
            [FromForm] Advertisement contentObject)
        {
            contentObject.RecordTime = DateTime.UtcNow;
            contentObject.UpdateTime = DateTime.UtcNow;

            StringValues newsValue = string.Empty;
            Request.Form.TryGetValue("News", out newsValue);
            string news = newsValue.ToString();

            if (news != null)
            {
                if (news.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.News = true;
                    if (ModelState.Remove("News"))
                    {
                        ModelState.SetModelValue("News", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            StringValues enabledValue = string.Empty;
            Request.Form.TryGetValue("Enabled", out enabledValue);
            string enabled = enabledValue.ToString();

            if (enabled != null)
            {
                if (enabled.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Enabled = true;
                    if (ModelState.Remove("Enabled"))
                    {
                        ModelState.SetModelValue("Enabled", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            return base.CreateFileContent(contentObject);
        }

        public override Task<JsonResult> UpdateFileContent(
            [Bind(include: new string[] { "Uid", "ReferenceId", "RecordTime", "UpdateTime", "Heading","SubHeading","Detail","Picture","Video","Link1","Link2","Source","Page","Location","SortOrder","News","Enabled", "RowVersion" })]
            [FromForm] Advertisement contentObject)
        {

            contentObject.UpdateTime = DateTime.UtcNow;

            StringValues newsValue = string.Empty;
            Request.Form.TryGetValue("News", out newsValue);
            string news = newsValue.ToString();

            if (news != null)
            {
                if (news.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.News = true;
                    if (ModelState.Remove("News"))
                    {
                        ModelState.SetModelValue("News", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            StringValues enabledValue = string.Empty;
            Request.Form.TryGetValue("Enabled", out enabledValue);
            string enabled = enabledValue.ToString();

            if (enabled != null)
            {
                if (enabled.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Enabled = true;
                    if (ModelState.Remove("Enabled"))
                    {
                        ModelState.SetModelValue("Enabled", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            return base.UpdateFileContent(contentObject);
        }

        protected override async Task<Advertisement> SaveNewFileContent(Advertisement contentObject, string fileName)
        {
            StringValues uploadTypeStructure = string.Empty;
            Request.Form.TryGetValue("uploadType", out uploadTypeStructure);

            var uploadType = uploadTypeStructure.ToString();
            if (!string.IsNullOrEmpty(uploadType))
                if (uploadType != null)
            {
                if (uploadType.Equals("image", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Picture = fileName;
                }
                else if (uploadType.Equals("video", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Video = fileName;
                }
            }
            else
            {
                contentObject.Picture = fileName;
            }

            //Empty task to avoid warning
            var awaitingTask = new Task(() =>
            { });
            await awaitingTask.ConfigureAwait(false);

            return GetRepository().Create(contentObject);
        }

        protected override async Task<Advertisement> SaveExistingFileContent(Advertisement contentObject, string fileName = null)
        {
            var repository = GetRepository();
            var record = repository.Read(contentObject.Uid.ToString());

            StringValues uploadTypeStructure = string.Empty;
            Request.Form.TryGetValue("uploadType", out uploadTypeStructure);

            var uploadType = uploadTypeStructure.ToString();
            if (uploadType != null)
            {
                if (uploadType != null)
                {
                    if (uploadType.Equals("image", StringComparison.OrdinalIgnoreCase))
                    {
                        record.Picture = fileName;
                    }
                    else if (uploadType.Equals("video", StringComparison.OrdinalIgnoreCase))
                    {
                        record.Video = fileName;
                    }
                }
                else
                {
                    record.Picture = fileName;
                }
            }

            //Empty task to avoid warning
            var awaitingTask = new Task(() =>
            { });
            await awaitingTask.ConfigureAwait(false);

            return repository.Update(record);
        }
    }
}