using AutoMapper;
using Cadastro_Cliente_Api.Data;
using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Cliente_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController:ControllerBase
    {
        IUsuarioDao _usuarioDao;

        public UsuarioController(IUsuarioDao usuarioDao)
        {
            _usuarioDao = usuarioDao;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            await _usuarioDao.CadastraAsync(dto);
            return Ok("Usuario Cadastrado!");

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
           var token = await _usuarioDao.LoginAsync(dto);
            return Ok(token);
        }
    }
}
