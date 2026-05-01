using Core.Entity;
using Core.Input;
using Core.Repository;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FiapCloudGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private IBibliotecaRepository _bibliotecaRepository;
        public BibliotecaController(IBibliotecaRepository bibliotecaoRepository)
        {
            _bibliotecaRepository = bibliotecaoRepository;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Post([FromRoute] int usuarioId, int jogoId)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
