using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public override List<Categoria> GetAll()
        {
            List<Categoria> list = new List<Categoria>();
            
            using (WarrenContext context = new WarrenContext()) 
            {
                list = context.Categoria.Include("Produto").ToList();
            }
            return list;    
        }
    }
}
