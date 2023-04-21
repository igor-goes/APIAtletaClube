using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;


namespace AtletaClubeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        protected readonly BaseRepository<Atleta> _repository;
        public AtletaController(BaseRepository<Atleta> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(_repository.GetByID(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpDelete]
        [Route("deletar")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            _repository.Delete(id);
            return Ok();
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Post(Atleta atleta)
        {
            if (atleta == null) return BadRequest();
            _repository.Post(atleta);
            return Ok();
        }
        [HttpPut]
        [Route("alterar")]
        public IActionResult Update(Atleta atleta)
        {
            if (atleta == null) return BadRequest();
            _repository.Update(atleta);
            return Ok();
        }
    }
}
