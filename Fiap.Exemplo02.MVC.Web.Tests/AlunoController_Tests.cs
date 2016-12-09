using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.Exemplo02.MVC.Web.Controllers;
using System.Web.Mvc;
using Fiap.Exemplo02.MVC.Web.ViewModels;

namespace Fiap.Exemplo02.MVC.Web.Tests
{
    [TestClass]
    public class AlunoController_Tests
    {
        public AlunoController alunoController;

        [TestInitialize]
        public void Init()
        {
            alunoController = new AlunoController();
        }

        [TestMethod]
        public void AlunoController_Cadastrar_Ok()
        {
            var viewModel = new AlunoViewModel()
            {
                Nome = "John Connor",
                Bolsa = true,
                DataNascimento = Convert.ToDateTime("10/10/1970"),
                Desconto = 35,
                GrupoId = 1
            };

            ActionResult result = (ActionResult) alunoController.Cadastrar(viewModel);
            Assert.IsNotNull(result);

            ViewResult vr = (ViewResult) result;
            var model = vr.ViewData.Model as AlunoViewModel;

            Assert.AreEqual(model.Mensagem, "Aluno Cadastrado");
        }
    }
}
