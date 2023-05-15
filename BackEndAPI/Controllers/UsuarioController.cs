using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AtletaClubeAPI.Controllers
{
    [Route("/api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        protected readonly BaseRepository<Usuario> _repository;
        public UsuarioController(BaseRepository<Usuario> repository)
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

        [HttpGet("{email}/{senha}")]
        public IActionResult GetLogin(string email, string senha) 
        {
           var usuarios = _repository.GetLogin(email, senha);
            // Faz algo com o resultado
            if (usuarios.Count() != 0)
            {
                foreach (var usuario in usuarios)
                {
                    return Content("Usuario encontrado:" + usuario.Nome + usuario.Sobrenome);
                }
            }
            else
            {
                return Content("Nenhum usuario encontrado com email: " + email);
            }
            return Content("");
        }

        [HttpDelete("deletar/{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            _repository.Delete(id);
            return Ok();
        }

        [HttpPost("inserir")]
        public IActionResult Post([FromBody] Usuario atleta)
        {
            if (atleta == null) return BadRequest();
            _repository.Post(atleta);
            return Ok();
        }

        [HttpPut("alterar")]
        public IActionResult Update([FromBody] Usuario atleta)
        {
            if (atleta == null) return BadRequest();
            _repository.Update(atleta);
            return Ok();
        }
    }
}
