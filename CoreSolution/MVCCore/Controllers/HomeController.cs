using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;
using System.Diagnostics;

namespace MVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            int port = int.Parse(_configuration.GetSection("port").Value);
            string connectionstring = _configuration.GetConnectionString("connection");
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bechir()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}