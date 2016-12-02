using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Fiap.Exemplo02.Persistencia.Repositories
{
    public interface IGenericRepository<T>
    {
        void Cadastrar(T entidade);
        void Alterar(T entidade);
        void Remover(int id);
        ICollection<T> Listar();
        T BuscarPorId(int id);
        ICollection<T> BuscarPor(Expression<Func<T, bool>> filtro);
    }
}
