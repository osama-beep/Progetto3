using Microsoft.AspNetCore.Mvc;
using Progetto3.Models;
using System.Linq;

namespace Progetto3.Controllers
{
    public class ArticoliController : Controller
    {
        public IActionResult Index(string marca)
        {
            var articoli = ArticoloRepository.GetAll();

            if (!string.IsNullOrEmpty(marca))
            {
                articoli = articoli.Where(a => a.Nome.Contains(marca, StringComparison.OrdinalIgnoreCase));
                ViewBag.Marca = marca;
            }
            else
            {
                ViewBag.Marca = "Sneakers";
            }

            var marchiPresenti = articoli.Select(a => a.Nome.Split(' ')[0]).Distinct();
            if (marchiPresenti.Count() == 1)
            {
                ViewBag.Marca = marchiPresenti.First();
            }

            return View(articoli);
        }

        public IActionResult Dettaglio(int id)
        {
            var articolo = ArticoloRepository.GetById(id);
            if (articolo == null)
            {
                return NotFound();
            }
            return View(articolo);
        }
    }
}