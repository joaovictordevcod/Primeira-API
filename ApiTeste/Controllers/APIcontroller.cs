using ApiTeste.Cliente;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route ("api/clientes")]//roteamento
    public class APIController : ControllerBase//herda as caracteristicas da classe pre-definida
    {
        private ArrayList _clientes;

        public APIController() 
        {
            _clientes = new ArrayList();
        }
         
        //Controller para encontrar todos clientes
        [HttpGet("encontrar-cliente")]
        public ActionResult Get()
        {
            return Ok("Clientes encontrado");
        }

        //Controller get by id
        [HttpGet("get-by-id/{ID}")]
        public ActionResult GetById(int ID)
        {
            return Ok("Cliente de id x encontrado");
        }

        //Controller para cadastro de cliente pf
        [HttpPost("cadastro-de-cliente-pf")]
        public ActionResult Post([FromBody] ClientePF client)
        {
            return Ok("Cliente cadastrado");
        }

        //Controller para cadastro de cliente pj
        [HttpPost("cadastro-de-cliente-pj")]
        public ActionResult Post([FromBody] ClientePJ client)
        {
            return Ok("Cliente cadastrado");
        }

        //Controller para atualização de cliente
        [HttpPut("atualizar-cliente/{ID}")]
        public ActionResult Put(int ID,[FromBody] Client cliente)
        {
            return Ok("Cliente atualizado");
        }

        //Controller para exclusão de cliente
        [HttpDelete("excluir-cliente")]
        public ActionResult Delete()
        {
            return Ok("Cliente excluido com sucesso");
        }
    }
}
