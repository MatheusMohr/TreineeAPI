using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class ClasseService : IClasseService
    {
        public readonly IClasseRepository _classeRepository;
        public readonly IMapper _mapper;

        public ClasseService(IMapper mapper, IClasseRepository classeRepository)
        {
            _mapper = mapper;
            _classeRepository = classeRepository;
        }

        public void Salvar(ClasseDto classeDto)
        {
            var classe = _mapper.Map<Classe>(classeDto);
            _classeRepository.SalvarClasse(classe);
        }

        public void Editar(EditarClasseDto model)
        {
            var classe = _classeRepository.ObterPorId(model.Id);
            _mapper.Map(model, classe);
            _classeRepository.SalvarClasse(classe);
        }
        public List<ExibirClasseDto> BuscarTodos()
        {
            var classe = _classeRepository.PegarTodos();
            return _mapper.Map<List<ExibirClasseDto>>(classe);
        }
        public async Task Remover(long id)
        {
            await _classeRepository.RemoverClasse(id);
        }

    }
}
