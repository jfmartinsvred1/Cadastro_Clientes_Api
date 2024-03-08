using AutoMapper;
using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;

namespace Cadastro_Cliente_Api.Profiles
{
    public class UsuarioProfile:Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto,Usuario>();
        }
    }
}
