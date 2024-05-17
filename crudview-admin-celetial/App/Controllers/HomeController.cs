using Microsoft.AspNetCore.Mvc;
using WindnTrees.Abstraction.Core.Controllers;
using Application.Core.Models.Configuration;
using Microsoft.Extensions.Options;

namespace Application.Core.Controllers
{
    public class HomeController : BasicController
    {
        private ApplicationSettings applicationSettings { get; set; }

        public HomeController(IOptions<ApplicationSettings> options)
        {
            applicationSettings = options.Value;
        }

        public IActionResult Index()
        {   
            ViewData.Add("HeadingTitle", applicationSettings.HeadingTitle);

            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Documentation()
        {
            return View();
        }
    }
}
