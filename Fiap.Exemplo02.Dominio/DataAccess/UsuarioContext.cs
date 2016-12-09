using Fiap.Exemplo02.Dominio.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo02.Dominio.DataAccess
{
    // Gerencia os usuários no banco e na aplicação
    public class UsuarioContext : IdentityDbContext<Usuario>
    {
        public System.Data.Entity.DbSet<Fiap.Exemplo02.Dominio.Models.Usuario> Usuarios { get; set; }
    }
}
