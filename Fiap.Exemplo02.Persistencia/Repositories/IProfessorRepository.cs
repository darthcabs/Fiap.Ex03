using Fiap.Exemplo02.Dominio.Models;

namespace Fiap.Exemplo02.Persistencia.Repositories
{
    public interface IProfessorRepository : IGenericRepository<Professor>
    {
        void Promocao(int id, decimal valor);
    }
}
