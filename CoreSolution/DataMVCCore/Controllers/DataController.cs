using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;

namespace DataMVCCore.Controllers
{
    public class DataController : Controller
    {
        //Exemple de passage de parametres simples de la vue vers le contrôleur
        public IActionResult Somme(int a,int b)
        {
            int result = a + b; 
            
            return View();
        }

        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save([Bind("Id,Nom")] Personne personne)
        {
            System.IO.File.WriteAllText(@"D:\temp\personne.txt", personne.ToString());
            return View();
        }

        /// <summary>
        /// Cette méthode utilise ViewBag pour communiquer les données du contrôleur vers la vue
        /// </summary>
        /// <returns></returns>
        public IActionResult Affiche()
        {
            //Passage des données entres les vues au niveau du même contrôleur
            ViewBag.Machin = $"Le titre de la vue {DateTime.Now.Hour}: {DateTime.Now.Minute}";
            ViewData["message"] = $"Le titre de la vue {DateTime.Now.Hour}: {DateTime.Now.Minute}";
            //Passage des données entres les vues apparetenant à différents contrôleurs
            TempData["message"] = $"Le titre de la vue {DateTime.Now.Hour}: {DateTime.Now.Minute}";
            return View();
        }

    }

    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Id: {Id} et Nom: {Nom}";
        }
    }

}
