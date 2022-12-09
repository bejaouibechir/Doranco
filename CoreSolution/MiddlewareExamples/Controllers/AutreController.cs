using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MiddlewareExamples.Controllers
{
    public class AutreController : Controller
    {
        public IActionResult Index()
        {
            Response.StatusCode = (int)HttpStatusCode.ServiceUnavailable;
            if(Response.StatusCode== (int)HttpStatusCode.ServiceUnavailable)
            {
               return View();
            }
            return View();
        }

        public IActionResult Data()
        {
            return View();
        }
    }
}
