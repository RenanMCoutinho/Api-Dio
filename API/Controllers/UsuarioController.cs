using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class UsuarioController : ControllerBase
    {
        [HttpGet("obter-data-hora")]
        public IActionResult ObterDataHora()
        {
            var obj = new

            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
            };
            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá, {nome}! Bem-vindo(a) à nossa API.";
            return Ok(new { mensagem });
        }

    }


}
