using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;
        public EscolaController(IEscolaService escolaservice)
        {
            _escolaService = escolaservice;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost("Adicionar")]
        public IActionResult Adicionar(EscolaDto escola)
        {
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody]ExibirDto escola)
        {
            _escolaService.Editar(escola);
            return Ok();
        }

        [HttpGet("PegarTodos")]

        public IActionResult BuscarTodos()
        {
            var escola = _escolaService.BuscarTodos();
            return Ok(escola);
        }

        [HttpDelete("Remover")]

        public async Task<IActionResult> Remover(long id) {
            await _escolaService.Remover(id);
            return Ok();
        }   

    }
}
