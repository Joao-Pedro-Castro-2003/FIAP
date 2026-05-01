using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiapStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet("Pedido-seis-meses/{id:int}")]
        public IActionResult ClienteEPedidosSeisMeses([FromRoute] int id)
        {
            try
            {
                return Ok(_clienteRepository.ObterPedidosSeisMeses(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
