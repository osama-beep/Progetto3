using Microsoft.AspNetCore.Mvc;
using Progetto3.Models;
using System.Linq;

namespace Progetto3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var articoli = ArticoloRepository.GetAll();
            var articoliPerMarca = articoli
                .GroupBy(a => a.Nome.Split(' ')[0])
                .ToDictionary(g => g.Key, g => g.Take(3).ToList());

            ViewBag.MostraVisualizzaDiPiu = articoliPerMarca.ToDictionary(
                kvp => kvp.Key,
                kvp => ArticoloRepository.GetAll().Count(a => a.Nome.StartsWith(kvp.Key)) > 3
            );

            return View(articoliPerMarca);
        }

    }
}