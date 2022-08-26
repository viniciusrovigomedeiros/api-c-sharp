using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public  abstract class BaseModel //coloca o abstract para proibir de criar um objeto de class model (só serve para ser herdada)
    {
        [Key]
        public int Id { get; set; }
    }
}
