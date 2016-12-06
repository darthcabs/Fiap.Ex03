using Fiap.Exemplo02.Dominio.Models;
using Fiap.Exemplo02.Persistencia.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fiap.Exemplo02.Persistencia.Test
{
    [TestClass]
    public class GenericRepositoryTest
    {
        private GenericRepository<Aluno> _repository;
        private Entities _context;

        [TestInitialize]
        public void Init()
        {
            _context = new Entities();
            _repository = new GenericRepository<Aluno>(_context);
        }

        [TestMethod]
        public void Cadastrar_Ok()
        {
            Aluno alu = new Aluno()
            {
                Nome = "John Connor",
                DataNascimento = Convert.ToDateTime("01/01/1970"),
                Desconto = 10,
                Grupo = new Grupo() { Nome = "Grupo Teste"}
            };

            _repository.Cadastrar(alu);
            _context.SaveChanges();
        }
    }
}
