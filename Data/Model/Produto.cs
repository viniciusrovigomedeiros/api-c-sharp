using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; } = String.Empty;
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        [JsonIgnore]
        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}
