using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route ("api/clientes")]
    public class APIController : ControllerBase
    {
        [HttpGet("encontrar-Cliente")]
        public ActionResult Get()
        {
            return Ok("Clientes encontrado");
        }

        [HttpGet("get-by-id")]
        public ActionResult Get()
        {
            var bool= false;
            if (bool=true)
            {
                return Ok(); 
            }
            else
            {
                return BadRequest();
            }

        [HttpPost("Cadastro-de-Cliente")]
        public ActionResult Post()
        {
            return Ok("Cliente cadastrado");
        }

        [HttpPut("Atualizar-cliente")]
        public ActionResult Put()
        {
            return Ok("Cliente atualizado");
        }

        [HttpDelete( "Excluir-cliente")]
        public ActionResult Delete()
        {
            return Ok("Cliente excluido com sucesso");
        }
    }
}
