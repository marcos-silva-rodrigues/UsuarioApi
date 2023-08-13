using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsuarioApi.Data
{
    public class UsuarioDbContext : IdentityDbContext<Usuario>
    {

        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> opts): base(opts)
        {
            
        }
    }
}
