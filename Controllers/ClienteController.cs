using Cadastro_Cliente_Api.Data;
using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Cadastro_Cliente_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController:ControllerBase
    {
        IClienteDao _clienteDao;

        public ClienteController(IClienteDao clienteDao)
        {
            _clienteDao = clienteDao;
        }

        [HttpPost]
        public IActionResult PostClient(CreateClienteDto dto, [FromQuery]string token)
        {
            _clienteDao.PostCliente(dto,token);
            return Ok("Criado Com Sucesso");
        }
        [HttpGet]
        public IEnumerable<Cliente> GetClientes(string token) 
        {
            return _clienteDao.Clientes(token);
        }
    }
}
