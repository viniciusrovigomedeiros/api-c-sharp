using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
