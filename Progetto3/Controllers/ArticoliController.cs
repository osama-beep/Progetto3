using Microsoft.AspNetCore.Mvc;
using Progetto3.Models;

namespace Progetto3.Controllers
{
    public class ArticoliController : Controller
    {
        public IActionResult Index()
        {
            var articoli = ArticoloRepository.GetAll();
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