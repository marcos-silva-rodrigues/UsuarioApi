using Microsoft.AspNetCore.Identity;

namespace UsuarioApi.Data
{
    public class Usuario: IdentityUser
    {
        public Usuario(): base()
        {
            
        }
        public DateTime DataNascimento { get; set; }
    }
}
