using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class UsuarioController : GenericController<Usuario, UsuarioRepository>
    {
    }
}
