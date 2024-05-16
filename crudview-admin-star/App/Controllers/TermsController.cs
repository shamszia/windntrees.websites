using Microsoft.AspNetCore.Mvc;
using WindnTrees.Abstraction.Core.Controllers;

namespace Application.Core.Controllers
{
    public class TermsController : BasicController
    {
        // GET: Terms
        public IActionResult Index()
        {
            return View();
        }
    }
}