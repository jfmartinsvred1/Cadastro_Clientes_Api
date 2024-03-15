using AutoMapper;
using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace Cadastro_Cliente_Api.Data.EFcore
{
    public class ClienteDao : IClienteDao
    {

        IMapper _mapper;
        SignInManager<Usuario> _signInManager;
        CadastroClienteContext _context;

        public ClienteDao(IMapper mapper, SignInManager<Usuario> signInManager, CadastroClienteContext context)
        {
            _mapper = mapper;
            _signInManager = signInManager;
            _context = context;
        }

        public IEnumerable<Cliente> Clientes(string token)
        {
            string userUsername = new JwtSecurityToken(token).Claims.FirstOrDefault(c => c.Type == "username").Value;
            var clientes = _context.Clientes.Where(c=>c.UsuarioUsername == userUsername).ToList().OrderBy(c=>c.Nome);
            return clientes;
        }

        public void PostCliente(CreateClienteDto dto, string token)
        {
            Cliente cliente = _mapper.Map<Cliente>(dto);

            string username = new JwtSecurityToken(token).Claims.FirstOrDefault(c => c.Type == "username").Value;

            cliente.UsuarioUsername = username;

            var user = _signInManager.UserManager.Users.FirstOrDefault(u => u.UserName == cliente.UsuarioUsername);

            if (user != null)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
            else
            {
                throw new ApplicationException("Usuario pai nao cadastrado");
            }
            

        }

    }
}
