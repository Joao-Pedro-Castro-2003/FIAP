using Core.Dto;
using Core.Entity;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiapCloudGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginDto LoginDto)
        {
            try
            {
                var token = _authRepository.Login(LoginDto);
                return Ok(token);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
