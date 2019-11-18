using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Entities;
using Restaurante.Repository.Data;
using Restaurante.Repository.Interfaces;

namespace Restaurante.Repository.Repository
{
    public class ConsumoRepository : IConsumoRepository
    {
        private DataContext context;

        public ConsumoRepository(DataContext context)
        {
            this.context = context;
        }

        public Consumo GetByID(int id)
        {
            return context.consumos.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<Consumo> GetAll()
        {
            return context.consumos.ToList().OrderBy(x => x.id);
        }

        public void Create(Consumo consumo)
        {
            context.Entry(consumo).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Consumo consumo)
        {
            context.Entry(consumo).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.consumos.Remove(this.GetByID(id));
            context.SaveChanges();
        }

        List<Consumo> IBaseRepository<Consumo>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Consumo GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}