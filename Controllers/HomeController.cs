using Microsoft.AspNetCore.Mvc;

namespace WebSockets2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
