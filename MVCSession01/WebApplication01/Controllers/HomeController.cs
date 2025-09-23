using Microsoft.AspNetCore.Mvc;

namespace WebApplication01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
