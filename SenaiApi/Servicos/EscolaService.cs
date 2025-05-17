using AutoMapper;
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
        public List<EscolaDto> BuscarTodos()
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<EscolaDto>>(escolas);
        }
        public void Remover()
        {
       
        }
    }
}
