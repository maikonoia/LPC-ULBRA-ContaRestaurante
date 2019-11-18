using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Domain.Entities;
using Restaurante.Repository.Interfaces;

namespace Restaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private IRestauranteRepository repository;
        private IConsumoRepository consumoRepository;

        public RestauranteController(IRestauranteRepository repository, IConsumoRepository cosumoRepository)
        {
            this.repository = repository;
            this.consumoRepository = consumoRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Restaurante>> Get()
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetAll()
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Restaurante> Get(int id)
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetByID(id)
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Restaurante entity)
        {
            var consumo = consumoRepository.GetByID(entity.idconsumo);

            if (consumo != null)
                entity.consumo = consumo;

            repository.Create(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Restaurante entity)
        {
            var consumo = consumoRepository.GetByID(entity.idconsumo);

            if (consumo != null)
                entity.consumo = consumo;

            repository.Update(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}