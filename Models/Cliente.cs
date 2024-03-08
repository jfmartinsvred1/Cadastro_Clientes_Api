using System.ComponentModel.DataAnnotations;

namespace Cadastro_Cliente_Api.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        [MaxLength(11)]
        public string Cpf { get; set; }
    }
}
