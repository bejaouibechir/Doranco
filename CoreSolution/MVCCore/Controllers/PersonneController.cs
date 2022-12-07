using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;
using MVCCore.Services;

namespace MVCCore.Controllers
{
    [Route("/Personne/Test")]
    public class PersonneController : Controller
    {
        private readonly IEventLogService _logservice;
        Model _personnes;

        public PersonneController(IEventLogService logservice)
        {
            _personnes = new Model();
            _logservice = logservice;
        }

        public IActionResult Index()
        {
            return View(_personnes);
        }

        [HttpGet]
        public IActionResult Test()
        {
            _logservice.Log("Quelque choses de serieux ce passe au niveau de Test", 
                NiveauAlerte.Avertissement);
            return View();
        }


        
    }
}
