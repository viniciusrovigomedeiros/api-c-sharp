using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public  class Planta : BaseModel
    {
        public string Nome { get; set; } = String.Empty;
        public string Cor { get; set; } = String.Empty;
        public string Tipo { get; set; } = String.Empty;
    }
}
