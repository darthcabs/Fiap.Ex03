using Fiap.Exemplo02.Dominio.Models;
using Fiap.Exemplo02.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Fiap.Exemplo02.Service.Controllers
{
    [EnableCors(origins:"*",headers:"*", methods:"*")]
    public class AlunoController : ApiController
    {
        #region FIELD
        private UnitOfWork _unit = new UnitOfWork();
        #endregion

        #region GET
        public ICollection<Aluno> Get()
        {
            return _unit.AlunoRepository.Listar();
        }

        public Aluno Get(int id)
        {
            return _unit.AlunoRepository.BuscarPorId(id);
        }
        #endregion

        #region POST
        public IHttpActionResult Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _unit.AlunoRepository.Cadastrar(aluno);
                _unit.Salvar();

                var uri = Url.Link("DefaultApi", new { id = aluno.Id });
                return Created<Aluno>(new Uri(uri), aluno);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        #endregion

        #region PUT
        public IHttpActionResult Put(int id, Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _unit.AlunoRepository.Alterar(aluno);
                _unit.Salvar();
                
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        #endregion

        #region DISPOSE
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
        #endregion
    }
}