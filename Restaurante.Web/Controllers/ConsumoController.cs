using Microsoft.AspNetCore.Mvc;
using Restaurante.Domain.Entities;
using Restaurante.Repository.Interfaces;

namespace Restaurante.Web.Controllers
{
    public class ConsumoController : Controller
    {
        private IConsumoRepository consumoRepository;

        public ConsumoController(IConsumoRepository consumoRepository)
        {
            this.consumoRepository = consumoRepository;
        }

        public IActionResult Index()
        {
            return View(consumoRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            return View(consumoRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Consumo entity)
        {
            consumoRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(consumoRepository.GetById(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(Consumo entity)
        {
            consumoRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            consumoRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}