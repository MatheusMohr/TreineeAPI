using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class ProfessorService : IProfessorService
    {
        public readonly IProfessorRepository _professorRepository;
        public readonly IMapper _mapper;
        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }
        public void Salvar(ProfessorDto professorDto)
        {
            var professor = _mapper.Map<Professor>(professorDto);
            _professorRepository.Salvar(professor);
        }

        public void Editar(EditarProfessorDto model)
        {
            var professor = _professorRepository.ObterPorId(model.Id);
            _mapper.Map(model, professor);
            _professorRepository.Salvar(professor);
        }
        public List<ExibirProfessorDto> BuscarTodos()
        {
            var professor = _professorRepository.PegarTodos();
            return _mapper.Map<List<ExibirProfessorDto>>(professor);
        }
        public async Task Remover(long id)
        {
            await _professorRepository.Remover(id);
        }
    }
}
