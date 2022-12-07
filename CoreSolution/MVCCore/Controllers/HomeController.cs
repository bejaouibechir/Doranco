using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;
using MVCCore.Services;
using System.Diagnostics;

namespace MVCCore.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IEventLogService _logservice;

        public HomeController(IConfiguration configuration,IEventLogService logservice) //Injection du service
        {
            _configuration = configuration;
            _logservice = logservice;
        }

        public IActionResult Index(string id)
        {
            //int port = int.Parse(_configuration.GetSection("port").Value);
            //string connectionstring = _configuration.GetConnectionString("connection");
            //string password = _configuration["password"];

            _logservice.Log("L'action Index du contrôleur " +
                "HomeController est lancée", NiveauAlerte.Information);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bechir()
        {
            _logservice.Log("L'action Bechir du contrôleur " +
                 "HomeController est lancée", NiveauAlerte.Information);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}