using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Categoria : BaseModel
    {
        public string Nome { get; set; } = String.Empty;    
        public string Descricao { get; set; } = String.Empty;

        public List<Produto> Produto { get; set; }
    }
}
