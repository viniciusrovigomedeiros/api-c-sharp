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
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public override  List<Produto> GetAll()
        {
            List<Produto> list = new List<Produto>();
            
            using (WarrenContext context = new WarrenContext()) 
            {
                list = context.Produto.Include("Categoria").ToList();
            }
            return list;
        }
    }
}
