using Microsoft.AspNet.Identity.EntityFramework;

namespace Fiap.Exemplo02.Dominio.Models
{
    public class Usuario : IdentityUser
    {
        public string Name { get; set; }
    }
}
