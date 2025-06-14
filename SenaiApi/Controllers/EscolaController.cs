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


        [HttpPost]
        [Route("Salvar")]
        public IActionResult Salvar([FromBody] EditarEscolaDto escola)
        {
            if (escola == null)
                return BadRequest("Escola não pode ser nula");
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpGet]
        [Route("Obter_Por_Id")]
        public IActionResult PegarPorId(long id)
        {
            var escolas = _escolaService.PegarPorId(id);
            return Ok(escolas);
        }

        [HttpGet("Buscar_Escolas")]

        public IActionResult BuscarTodos()
        {
            var escola = _escolaService.BuscarTodos();
            return Ok(escola);
        }

        [HttpDelete]
        [Route("Remover_Escola")]

        public async Task<IActionResult> Remover(long id) {
            await _escolaService.Remover(id);
            return Ok();
        }   

    }
}
