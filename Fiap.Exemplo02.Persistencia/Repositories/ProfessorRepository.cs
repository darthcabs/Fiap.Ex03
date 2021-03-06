﻿using Fiap.Exemplo02.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Persistencia.Repositories
{
    public class ProfessorRepository : GenericRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(Entities context):base(context)
        {
        }

        public void Promocao(int id, decimal valor)
        {
            var professor = BuscarPorId(id);
            //Aumenta o valor em %
            professor.Salario += professor.Salario * valor ;
        }
    }
}