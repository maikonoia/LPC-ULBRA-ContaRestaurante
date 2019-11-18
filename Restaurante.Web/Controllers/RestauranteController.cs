using Microsoft.AspNetCore.Mvc;
using Restaurante.Domain.Entities;
using Restaurante.Repository.Interfaces;

namespace Restaurante.Web.Controllers
{
    public class RestauranteController : Controller
    {
        private IRestauranteRepository restauranteRepository;
        private IConsumoRepository consumoRepository;

        public RestauranteController(IRestauranteRepository restauranteRepository, IConsumoRepository consumoRepository)
        {
            this.restauranteRepository = restauranteRepository;
            this.consumoRepository = consumoRepository;
        }

        public IActionResult Index()
        {
            ViewBag.menorConsumo = restauranteRepository.GetMenorConsumo();
            ViewBag.maiorConsumo = restauranteRepository.GetMaiorConsumo();
            return View(restauranteRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            ViewBag.Consumos = consumoRepository.GetAll();
            return View(restauranteRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Consumos = consumoRepository.GetAll();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Restaurante entity)
        {
            entity.consumo = consumoRepository.GetById(entity.consumo.id);
            restauranteRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Consumos = consumoRepository.GetAll();
            return View(restauranteRepository.GetById(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(Restaurante entity)
        {
            entity.consumo = consumoRepository.GetById(entity.consumo.id);
            restauranteRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            restauranteRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}