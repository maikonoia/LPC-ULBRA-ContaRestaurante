using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Entities;
using Restaurante.Repository.Data;
using Restaurante.Repository.Interfaces;

namespace Restaurante.Repository.Repository
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private DataContext context;

        public RestauranteRepository(DataContext context)
        {
            this.context = context;
        }

        public Restaurante GetByID(int id)
        {
            return context.restaurantes.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<Restaurante> GetAll()
        {
            return context.restaurantes.Include(x=>x.id).ToList().OrderBy(x => x.id);
        }

        public void Create(Restaurante consumo)
        {
            context.Entry(consumo).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Restaurante consumo)
        {
            context.Entry(consumo).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.restaurantes.Remove(this.GetByID(id));
            context.SaveChanges();
        }

        public Restaurante GetMenorConsumo()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.nome).First() : null;
        }

        public Restaurante GetMaiorConsumo()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.nome).Last() : null;
        }

        List<Restaurante> IBaseRepository<Restaurante>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Restaurante GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}