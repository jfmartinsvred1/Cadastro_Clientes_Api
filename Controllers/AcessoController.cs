using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Cliente_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcessoController:ControllerBase
    {
        [HttpGet]
        [Authorize(Policy ="UsuarioCadastrado")]
        public IActionResult Get()
        {
            return Ok("Acesso Permitido");
        }
    }
}
