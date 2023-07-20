using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace notet.UI.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy ="AdminPolicy")]
    public class DashController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
