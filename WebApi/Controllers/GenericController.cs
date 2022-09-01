using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repo;

        public GenericController()
        {
            this.repo = Activator.CreateInstance<R>();
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
