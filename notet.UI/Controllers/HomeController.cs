using Microsoft.AspNetCore.Mvc;

namespace notet.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
