using Microsoft.AspNetCore.Mvc;

namespace EternaDB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
