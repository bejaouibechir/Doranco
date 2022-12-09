using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Paris.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
