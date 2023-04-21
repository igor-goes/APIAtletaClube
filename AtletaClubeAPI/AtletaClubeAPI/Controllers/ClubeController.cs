using Domain.Entities;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AtletaClubeAPI.Controllers
{
    [Route("api/[controller]")]
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

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            _repository.Delete(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Clube clube)
        {
            if (clube == null) return BadRequest();
            _repository.Post(clube);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Clube clube)
        {
            if (clube == null) return BadRequest();
            _repository.Update(clube);
            return Ok();
        }
    }
}
