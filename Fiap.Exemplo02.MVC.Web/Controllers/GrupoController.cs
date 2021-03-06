﻿using Fiap.Exemplo02.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Web.Controllers
{
    public class GrupoController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Grupo grupo)
        {
            var con = new Entities();
            con.Grupo.Add(grupo);
            con.SaveChanges();
            TempData["mensagem"] = "Cadastrado com sucesso!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var con = new Entities();
            var l = con.Grupo.ToList();
            return View(l);
        }

       
    }
}