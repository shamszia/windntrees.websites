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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WindnTrees.Abstraction.Core.Controllers;
using WindnTrees.Abstraction.Core.Results;
using WindnTrees.CRUDS.Repository.Core;

namespace Application.Core.Areas.MyAccount.Controllers
{
    [Area("MyAccount")]
    [Authorize(Roles = "mngr_myaccount")]
    public class ReferenceController : AntiforgeryFormController<Reference>
    {
        private ApplicationSettings applicationSettings;

        public ReferenceController(IOptions<ApplicationSettings> options)
        {
            applicationSettings = options.Value;

            FilesExtensionsLimit = applicationSettings.AllowedExtensions;
            FileLengthLimit = int.Parse(applicationSettings.MaxFileSizeInKB);
        }

        public IActionResult Index(string id)
        {
            if (id != null)
            {
                ViewData.Add(new KeyValuePair<string, object>("ReferenceID", id));
            }
            return View();
        }

        protected override DbContext GetDBContext()
        {
            return new LocalAppContext();
        }

        protected override CRUDLMRepository<Reference> GetRepository()
        {
            return new ReferenceRepository((LocalAppContext)GetDBContext());            
        }

        protected override string GetUploadFolderPath()
        {
            StringValues uploadTypeStructure = string.Empty;
            Request.Form.TryGetValue("uploadType", out uploadTypeStructure);

            var uploadType = uploadTypeStructure.ToString();            

            if (uploadType != null)
            {
                if (uploadType.Equals("readable", StringComparison.OrdinalIgnoreCase))
                {
                    return System.IO.Path.Combine(new string[] { Startup.ENV.WebRootPath, "uploads", "readable" });
                    //return string.Format("{0}\\uploads\\readable\\", Startup.ENV.WebRootPath);
                }
                else if (uploadType.Equals("image", StringComparison.OrdinalIgnoreCase))
                {
                    return System.IO.Path.Combine(new string[] { Startup.ENV.WebRootPath, "uploads", "image" });
                    //return string.Format("{0}\\uploads\\image\\", Startup.ENV.WebRootPath);
                }
                else if (uploadType.Equals("video", StringComparison.OrdinalIgnoreCase))
                {
                    return System.IO.Path.Combine(new string[] { Startup.ENV.WebRootPath, "uploads", "video" });
                    //return string.Format("{0}\\uploads\\video\\", Startup.ENV.WebRootPath);
                }
            }

            return System.IO.Path.Combine(new string[] { Startup.ENV.WebRootPath, "uploads" });
            //return string.Format("{0}\\uploads\\", Startup.ENV.WebRootPath);
        }

        public override Task<JsonResult> CreateFileContent([FromForm] Reference contentObject)
        {
            //for model validation will be overriden by repository
            contentObject.Uid = Guid.NewGuid();
            ModelState.Remove("Uid");
            ModelState.SetModelValue("Uid", new ValueProviderResult(contentObject.Uid.ToString(), System.Threading.Thread.CurrentThread.CurrentCulture));
            
            StringValues DownloadValue = string.Empty;
            Request.Form.TryGetValue("Download", out DownloadValue);
            string Download = DownloadValue.ToString();

            if (Download != null)
            {
                if (Download.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Download = true;
                    if (ModelState.Remove("Download"))
                    {
                        ModelState.SetModelValue("Download", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            StringValues SizeValue = string.Empty;
            Request.Form.TryGetValue("Size", out SizeValue);
            string Size = SizeValue.ToString();

            if (string.IsNullOrEmpty(Size))
            {
                contentObject.Size = 0;
                if (ModelState.Remove("Size"))
                {
                    ModelState.SetModelValue("Size", new ValueProviderResult("0", System.Threading.Thread.CurrentThread.CurrentCulture));
                }
            }

            return base.CreateFileContent(contentObject);
        }

        public override Task<JsonResult> UpdateFileContent([FromForm] Reference contentObject)
        {
            StringValues DownloadValue = string.Empty;
            Request.Form.TryGetValue("Download", out DownloadValue);
            string Download = DownloadValue.ToString();

            if (Download != null)
            {
                if (Download.Equals("on", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Download = true;
                    if (ModelState.Remove("Download"))
                    {
                        ModelState.SetModelValue("Download", new ValueProviderResult("true", System.Threading.Thread.CurrentThread.CurrentCulture));
                    }
                }
            }

            return base.UpdateFileContent(contentObject);
        }

        protected override async Task<Reference> SaveNewFileContent(Reference contentObject, string fileName = null)
        {
            contentObject.ContentFile = fileName;
            contentObject.Size = Request.Form.Files[0].Length;

            contentObject.Readable = false;
            contentObject.Picture = false;
            contentObject.AudioVideo = false;

            StringValues uploadTypeStructure = string.Empty;
            Request.Form.TryGetValue("uploadType", out uploadTypeStructure);

            var uploadType = uploadTypeStructure.ToString();

            if (uploadType != null)
            {
                if (uploadType.Equals("readable", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Readable = true;

                }
                else if (uploadType.Equals("image", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.Picture = true;

                }
                else if (uploadType.Equals("video", StringComparison.OrdinalIgnoreCase))
                {
                    contentObject.AudioVideo = true;
                }
            }

            var memoryStream = new MemoryStream();
            await Request.Form.Files[0].CopyToAsync(memoryStream);
            contentObject.ContentBytes = memoryStream.GetBuffer();
            memoryStream.Close();

            return GetRepository().Create(contentObject);
        }

        protected override async Task<Reference> SaveExistingFileContent(Reference contentObject, string fileName = null)
        {
            var repository = GetRepository();
            var record = repository.Read(contentObject.Uid.ToString());

            if (!string.IsNullOrEmpty(fileName))
            {
                record.Name = contentObject.Name;
                record.Description = contentObject.Description;
                record.ContentFile = fileName;
                record.Size = Request.Form.Files[0].Length;

                record.Readable = false;
                record.Picture = false;
                record.AudioVideo = false;

                StringValues uploadTypeStructure = string.Empty;
                Request.Form.TryGetValue("uploadType", out uploadTypeStructure);

                var uploadType = uploadTypeStructure.ToString();

                if (uploadType != null)
                {
                    if (uploadType.Equals("readable", StringComparison.OrdinalIgnoreCase))
                    {
                        record.Readable = true;
                    }
                    else if (uploadType.Equals("image", StringComparison.OrdinalIgnoreCase))
                    {
                        record.Picture = true;
                    }
                    else if (uploadType.Equals("video", StringComparison.OrdinalIgnoreCase))
                    {
                        record.AudioVideo = true;
                    }
                }
            }

            var memoryStream = new MemoryStream();
            await Request.Form.Files[0].CopyToAsync(memoryStream);
            record.ContentBytes = memoryStream.GetBuffer();
            memoryStream.Close();

            return repository.Update(record);
        }

        [HttpGet]
        public ActionResult GetContent(string id)
        {
            try
            {
                var content = GetRepository().Read(id);
                return File(content.ContentBytes, "application/binary", content.ContentFile);
            }
            catch (Exception ex)
            {
                return GetObjectResultWithException(null, "Exception", ex.Message);
            }
        }

        [HttpGet]
        public ActionResult GetRegistrationContent(string id)
        {
            try
            {
                var content = GetRepository().List(new WindnTrees.ICRUDS.Standard.SearchInput { key = id, total = 1 }).FirstOrDefault();
                if (content != null)
                {
                    if (content.ContentBytes != null)
                    {
                        return File(content.ContentBytes, "application/binary", content.ContentFile);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return GetObjectResultWithException(null, "Exception", ex.Message);
            }
        }
    }
}