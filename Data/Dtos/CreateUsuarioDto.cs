using System.ComponentModel.DataAnnotations;

namespace Cadastro_Cliente_Api.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        public string NomeEmpresa { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cnpj { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
