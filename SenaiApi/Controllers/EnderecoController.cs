using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost("Adicionar_Endereço")]

        public IActionResult Adicionar(EnderecoDto endereco)
        {
            _enderecoService.Salvar(endereco);
            return Ok();
        }

        [HttpPost]
        [Route("Editar_Endereço")]
        public IActionResult Editar([FromBody] EditarEnderecoDto endereco)
        {
            _enderecoService.Editar(endereco);
            return Ok();
        }

        [HttpGet("Buscar_Endereços")]

        public IActionResult BuscarTodos()
        {
            var endereco = _enderecoService.BuscarTodos();
            return Ok(endereco);
        }

        [HttpDelete("Remover_Endereços")]

        public async Task<IActionResult> Remover(long id)
        {
            await _enderecoService.Remover(id);
            return Ok();
        }

    }
}
