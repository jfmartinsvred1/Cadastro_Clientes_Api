using Cadastro_Cliente_Api.Data.Dtos;

namespace Cadastro_Cliente_Api.Data
{
    public interface IUsuarioDao
    {
        Task CadastraAsync(CreateUsuarioDto dto);
        Task<string> LoginAsync(LoginUsuarioDto dto);
    }
}
