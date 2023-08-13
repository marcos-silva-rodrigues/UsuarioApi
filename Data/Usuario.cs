using Microsoft.AspNetCore.Identity;

namespace UsuarioApi.Data
{
    public class Usuario: IdentityUser
    {

        public DateTime DataNascimento { get; set; }
        public Usuario(): base()
        {
            
        }
        
    }
}
