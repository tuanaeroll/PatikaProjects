using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // IActionResult -> View dönecek olan metodların dönüş tipi
        public IActionResult About()
        {
            return View();
        }
    }
}
