using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (WarrenContext warrenContext = new WarrenContext())
            {
                list = warrenContext.Set<T>().ToList();
            }
            return list;
        }
        public virtual string Create(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Add(model);
                warrenContext.SaveChanges();
            }
            return "Criado";
        }

        public virtual string Delete(int id)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
            WarrenContext.Entry<T>(GetById(id).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            WarrenContext.SaveChanges();
                }
            return "Deletado";

        }
        public virtual T GetById(int id)
        {
            T model = null;
            using (WarrenContext warrenContext = new WarrenContext())
            {
                model = warrenContext.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Update(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
            WarrenContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            WarrenContext.SaveChanges();
            }
            return "Atualizado";
        }
    }
}
