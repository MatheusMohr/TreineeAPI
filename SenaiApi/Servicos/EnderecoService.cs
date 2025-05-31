using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class EnderecoService : IEnderecoService
    {
        public readonly IEnderecoRepository _enderecoRepository;
        public readonly IMapper _mapper;
        public EnderecoService(IMapper mapper, IEnderecoRepository enderecoRepository)
        {
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
        }

        public void Salvar(EnderecoDto enderecoDto)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDto);
            _enderecoRepository.Salvar(endereco);
        }

        public void Editar(EditarEnderecoDto model)
        {
            var endereco = _enderecoRepository.ObterPorId(model.Id);
            _mapper.Map(model, endereco);
            _enderecoRepository.Salvar(endereco);
        }
        public List<ExibirEnderecoDto> BuscarTodos()
        {
            var endereco = _enderecoRepository.PegarTodos();
            return _mapper.Map<List<ExibirEnderecoDto>>(endereco);
        }
        public async Task Remover(long id)
        {
            await _enderecoRepository.Remover(id);
        }
    }
}
