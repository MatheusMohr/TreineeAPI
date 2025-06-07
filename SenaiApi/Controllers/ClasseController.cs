using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IClasseService _classeService;

        public ClassesController(IClasseService classeService)
        {
            _classeService = classeService;
        }

        [HttpPost("Adicionar_Classe")]

        public IActionResult AdicionarClasse(ClasseDto classe)
        {
            _classeService.Salvar(classe);
            return Ok();
        }

        [HttpPost]
        [Route("Editar_Classe")]
        public IActionResult EditarClasse([FromBody] EditarClasseDto classe)
        {
            _classeService.Editar(classe);
            return Ok();
        }

        [HttpGet("Buscar_Classes")]

        public IActionResult BuscarTodos()
        {
            var classe = _classeService.BuscarTodos();
            return Ok(classe);
        }

        [HttpDelete("Remover_Classe")]

        public async Task<IActionResult> Remover(long id)
        {
            await _classeService.Remover(id);
            return Ok();
        }
    }
}
