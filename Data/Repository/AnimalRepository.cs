using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.context;
using Data.Model;

namespace Data.Repository
{


    public class AnimalRepository : BaseRepository<Animal>
    {
        public override List<Animal> GetAll()
        {
            List<Animal> list = new List<Animal>();
            WarrenContext warrenContext = new WarrenContext();
            list = warrenContext.Animal.ToList();
            return list;
        }
    }
}
