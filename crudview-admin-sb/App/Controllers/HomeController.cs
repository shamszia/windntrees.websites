using Microsoft.AspNetCore.Mvc;
using WindnTrees.Abstraction.Core.Controllers;

namespace Application.Core.Controllers
{
    public class HomeController : BasicController
    {
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {   
            return View();
        }

        public IActionResult Members()
        {
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
