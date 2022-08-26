using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T model)
        {

            return "Criado";
        }

        public virtual string Delete(int id)
        {
            return "Deletado";
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            return list;
        }

        public virtual T GetById(int id)
        {
            T model = null;
            return model;
        }

        public virtual string Update(T model)
        {
            return "Alterado";
        }
    }
}
