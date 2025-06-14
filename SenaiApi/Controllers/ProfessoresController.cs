using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessorService _professorService;
        public ProfessoresController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpPost("Adicionar_Professor")]
        public IActionResult Adicionar(ProfessorDto professor)
        {
            _professorService.Salvar(professor);
            return Ok();
        }

        [HttpPost]
        [Route("Editar_Professor")]
        public IActionResult Editar([FromBody] EditarProfessorDto professor)
        {
            _professorService.Editar(professor);
            return Ok();
        }

        [HttpGet("Buscar_Professor")]

        public IActionResult BuscarTodos()
        {
            var professor = _professorService.BuscarTodos();
            return Ok(professor);
        }

        [HttpDelete("Remover_Professor")]

        public async Task<IActionResult> Remover(long id)
        {
            await _professorService.Remover(id);
            return Ok();    
        }

    }
}
