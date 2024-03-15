using Cadastro_Cliente_Api.Data.Dtos;
using System.IdentityModel.Tokens.Jwt;

namespace Cadastro_Cliente_Api.Data
{
    public interface IClienteDao
    {
        void PostCliente(CreateClienteDto dto, string token);
    }
}
