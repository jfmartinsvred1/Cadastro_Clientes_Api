using Cadastro_Cliente_Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Cliente_Api.Data
{
    public class CadastroClienteContext:IdentityDbContext<Usuario>
    {
        public CadastroClienteContext(DbContextOptions<CadastroClienteContext> opts):base(opts)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
