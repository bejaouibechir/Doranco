using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;

namespace MVCCore.Controllers
{
    public class PersonneController : Controller
    {
        Model _personnes;

        public PersonneController()
        {
            _personnes = new Model();
        }

        public IActionResult Index()
        {
            return View(_personnes);
        }
    }
}
