using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AtletaClubeAPI.Controllers
{
    [Route("/api/atleta")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        protected readonly BaseRepository<Atleta> _repository;
        public AtletaController(BaseRepository<Atleta> repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(_repository.GetByID(id));
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [AllowAnonymous]
        [HttpDelete("deletar/{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            _repository.Delete(id);
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("inserir")]
        public IActionResult Post([FromBody] Atleta atleta)
        {
            if (atleta == null) return BadRequest();
            _repository.Post(atleta);
            return Ok();
        }

        [AllowAnonymous]
        [HttpPut("alterar")]
        public IActionResult Update([FromBody] Atleta atleta)
        {
            if (atleta == null) return BadRequest();
            _repository.Update(atleta);
            return Ok();
        }
    }
}
