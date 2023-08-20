using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class categorycontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
