using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.context;
using Data.Model;
using Data.Utils;

namespace Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override  string Create(Usuario model)
        {
            model.Senha = Criptografia.Criptografar(model.Senha);
            return base.Create(model);

        }
        public Usuario Logon(string senha, string email)
        {
            senha = Criptografia.Criptografar(senha);
            Usuario user = new Usuario();
            using (WarrenContext context = new WarrenContext()) {
                user = context.Usuario.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();

            }
            return user;
        }
    }
}
