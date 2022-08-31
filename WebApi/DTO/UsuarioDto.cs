using Data.Model;
using System.Text.Json.Serialization;

namespace WebApi.DTO
{
    public class UsuarioDto
    {
        public string email { get; set; }

        public string senha { get; set; }

    }
}