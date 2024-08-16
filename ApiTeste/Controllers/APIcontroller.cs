using ApiTeste.Cliente;
using ApiTeste.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ApiTeste.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class APIController : ControllerBase
    {
        public List<Client> Clientes { get; set; }

        public APIController()
        {
            Clientes = new List<Client>()
            {
                new Client{Nome= "jOAO",Telefone="984998591",Email="joao@gmail.com",Id=3}
            };
        }

        [HttpGet()]
        public ActionResult Get()
        {
            return Ok(Clientes);
        }

        [HttpGet("get-by-id/{Id}")]
        public ActionResult GetById(int Id)
        {
            var cliente = Clientes.Where(c => c.Id == Id).FirstOrDefault();
            if (cliente == null)
            {
                return NotFound($"Cliente com ID {Id} não encontrado.");
            }
            return Ok(cliente);
        }

        [HttpPost()]
        public ActionResult Post([FromBody]List<Client> clients)
        {
            Clientes.AddRange(clients);
            return Ok(Clientes);
        }

        [HttpPut("{Id}")]
        public ActionResult Put(int Id, [FromBody] Client clienteAtualizado)
        {
            return Ok("Cliente atualizado");
        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {
            return Ok("Cliente excluído com sucesso.");
        }
    }
}
