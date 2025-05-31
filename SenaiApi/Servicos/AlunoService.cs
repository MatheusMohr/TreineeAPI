using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class AlunoService : IAlunoService
    {
        public readonly IAlunoRepository _alunoRepository;
        public readonly IMapper _mapper;

        public AlunoService(IMapper mapper, IAlunoRepository alunoRepository)
        {
            _mapper = mapper;
            _alunoRepository = alunoRepository;
        }

        public void Salvar(AlunoDto alunoDto)
        {
            var aluno = _mapper.Map<Aluno>(alunoDto);
            _alunoRepository.SalvarAluno(aluno);
        }

        public void Editar(EditarAlunoDto model)
        {
            var aluno = _alunoRepository.ObterPorId(model.Id);
            _mapper.Map(model, aluno);
            _alunoRepository.SalvarAluno(aluno);
        }
        public List<ExibirAlunoDto> BuscarTodos()
        {
            var aluno = _alunoRepository.PegarTodos();
            return _mapper.Map<List<ExibirAlunoDto>>(aluno);
        }
        public async Task Remover(long id)
        {
            await _alunoRepository.RemoverAluno(id);
        }

    }
}
