using Microsoft.AspNetCore.Identity;

namespace Cadastro_Cliente_Api.Models
{
    public class Usuario:IdentityUser
    {
        
        public string NomeEmpresa { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cnpj { get; set; }
        public Usuario() : base() { }
    }
}
