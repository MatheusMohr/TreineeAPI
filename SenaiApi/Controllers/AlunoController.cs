using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost("Adicionar Aluno")]

        public IActionResult AdicionarAluno(AlunoDto aluno)
        {
            _alunoService.Salvar(aluno);
            return Ok();
        }

        [HttpPost]
        [Route("Editar Aluno")]
        public IActionResult EditarAluno([FromBody] EditarAlunoDto aluno)
        {
            _alunoService.Editar(aluno);
            return Ok();
        }

        [HttpGet("Buscar Alunos")]

        public IActionResult BuscarTodos()
        {
            var aluno = _alunoService.BuscarTodos();
            return Ok(aluno);
        }

        [HttpDelete("Remover Aluno")]

        public async Task<IActionResult> Remover(long id)
        {
            await _alunoService.Remover(id);
            return Ok();
        }
    }
}
