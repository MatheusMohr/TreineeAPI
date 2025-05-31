using SenaiApi.Entity;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IAlunoRepository
    {
        void SalvarAluno(Aluno aluno);
        Aluno ObterPorId(long id);
        List<Aluno> PegarTodos();
        Task RemoverAluno(long id);
    }
}
