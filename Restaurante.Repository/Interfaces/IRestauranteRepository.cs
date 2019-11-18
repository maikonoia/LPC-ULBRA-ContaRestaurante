using Restaurante.Domain.Entities;

namespace Restaurante.Repository.Interfaces
{
    public interface IRestauranteRepository : IBaseRepository<Restaurante>
    {
        Restaurante GetMenorConsumo();
        Restaurante GetMaiorConsumo();
    }
}