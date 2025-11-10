using Microsoft.AspNetCore.Mvc;

namespace VoAnhKiet_1150080143_Lab02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
