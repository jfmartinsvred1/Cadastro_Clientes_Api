using AutoMapper;
using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;

namespace Cadastro_Cliente_Api.Profiles
{
    public class ClienteProfile:Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
        }
    }
}
