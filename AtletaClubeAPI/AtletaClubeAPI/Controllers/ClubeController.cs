using Domain.Entities;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtletaClubeAPI.Controllers
{
    [Route("api/clube")]
    [ApiController]
    public class ClubeController : ControllerBase
    {
        protected readonly BaseRepository<Clube> _repository;
        public ClubeController(BaseRepository<Clube> repository)
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

        [HttpDelete("deletar/{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            _repository.Delete(id);
            return Ok();
        }

        [HttpPost("inserir")]
        public IActionResult Post([FromBody] Clube clube)
        {
            if (clube == null) return BadRequest();
            _repository.Post(clube);
            return Ok();
        }

        [HttpPut("alterar")]
        public IActionResult Update([FromBody] Clube clube)
        {
            if (clube == null) return BadRequest();
            _repository.Update(clube);
            return Ok();
        }
    }
}
