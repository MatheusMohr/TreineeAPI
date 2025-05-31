using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class EscolaService : IEscolaService
    {
        public readonly IEscolaRepository _escolaRepository;
        public readonly IMapper _mapper;

        public EscolaService(IMapper mapper, IEscolaRepository escolaRepository)
        {
            _mapper = mapper;
            _escolaRepository = escolaRepository;
        }

        public void Salvar(EscolaDto escolaDto)
        {
            var escola = _mapper.Map<Escola>(escolaDto);    
            _escolaRepository.Salvar(escola);
        }

        public void Editar(EditarEscolaDto model)
        {
            var escolas = _escolaRepository.ObterPorId(model.Id);
            _mapper.Map(model, escolas);
            _escolaRepository.Salvar(escolas);
        }
        public List<ExibirEscolaDto> BuscarTodos()
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<ExibirEscolaDto>>(escolas);
        }
        public async Task Remover(long id)
        {
            await _escolaRepository.Remover(id);
        }
    }
}
