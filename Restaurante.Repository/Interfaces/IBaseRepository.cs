using System.Collections.Generic;

namespace Restaurante.Repository.Interfaces
{
    public interface IBaseRepository<Entity> 
        where Entity : class
    {
        void Create(Entity obj);
        List<Entity> GetAll();
        void Update(Entity obj);
        Entity GetById(int id);
        void Delete(int id);
    }
}