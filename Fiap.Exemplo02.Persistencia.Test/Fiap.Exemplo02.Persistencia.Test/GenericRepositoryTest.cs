using Fiap.Exemplo02.Dominio.Models;
using Fiap.Exemplo02.Persistencia.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity.Infrastructure;

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
        [ExpectedException(typeof(DbUpdateException))]
        public void Cadastrar_Ok()
        {
            Aluno alu = new Aluno()
            {
                Nome = "John Connor",
                DataNascimento = Convert.ToDateTime("01/01/1970"),
                Desconto = 10,
                GrupoId = 8
            };

            _repository.Cadastrar(alu);
            var ret = _context.SaveChanges();

//            Assert.AreEqual(2, ret);        //Valida a quantidade de registros afetados pelo commit (2 - Aluno e Grupo)
//            Assert.AreNotEqual(alu.Id, 0);  //Valida se foi gerada uma chave no banco de dados
        }
    }
}
