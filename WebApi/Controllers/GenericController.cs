using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class GenericController<T> : ControllerBase where T : BaseModel
    {
        private BaseRepository<T> repo;

        public GenericController()
        {
            this.repo = new BaseRepository<T>();
        }

        [HttpGet]
        public List<T> Get()
        {
            return repo.GetAll();
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return repo.GetById(id);
        }
        [HttpPost]
        public string Post(T model)
        {
            return repo.Create(model);
        }
        [HttpPut]
        public string Put(T model)
        {
            return repo.Update(model);
        }
        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return repo.Delete(id);
        }
    }

}
