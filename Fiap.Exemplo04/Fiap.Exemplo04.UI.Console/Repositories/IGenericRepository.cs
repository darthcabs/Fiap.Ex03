using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.UI.Console.Repositories
{
    public interface IGenericRepository<T>
    {
        ICollection<T> Listar();
        T BuscarPorId(int id);
        void Cadastrar(T entidade);
    }
}
