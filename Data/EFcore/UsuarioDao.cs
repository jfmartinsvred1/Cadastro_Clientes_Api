using AutoMapper;
using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;
using Cadastro_Cliente_Api.Service;
using Microsoft.AspNetCore.Identity;

namespace Cadastro_Cliente_Api.Data.EFcore
{
    public class UsuarioDao : IUsuarioDao
    {
        IMapper _mapper;
        UserManager<Usuario> _userManager;
        SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioDao(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task CadastraAsync(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            IdentityResult result = await _userManager.CreateAsync(usuario, dto.Password);

            if (!result.Succeeded) {
                throw new Exception("Usuario nao cadastrado");
            }
        }

        public async Task<string> LoginAsync(LoginUsuarioDto dto)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false,false);

            if(!result.Succeeded)
            {
                throw new ApplicationException("Usuario nao autenticado");
            }

            var user = _signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName== dto.Username.ToUpper());

            var token = _tokenService.GenerateToken(user);
            return token;
        }

        
    }
}
