using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessController : ControllerBase
    {
        [HttpPost("Logon")]
        public Usuario Logon(UsuarioDto UsuarioDto)
        {
            UsuarioRepository repo = new UsuarioRepository();
            Usuario user = repo.Logon(UsuarioDto.email, UsuarioDto.senha);
            return user;
        }
    }
}
