using System.ComponentModel.DataAnnotations;

namespace Cadastro_Cliente_Api.Data.Dtos
{
    public class CreateClienteDto
    {
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        [MaxLength(11)]
        public string Cpf { get; set; }
        //public string UsuarioUsername { get; set; }
    }
}
