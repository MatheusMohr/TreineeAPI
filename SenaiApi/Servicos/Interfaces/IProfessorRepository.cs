using SenaiApi.Entity;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IProfessorRepository
    {
        void Salvar(Professor professor);
        Professor ObterPorId(long id);
        List<Professor> PegarTodos();
        Task Remover(long id);
    }
}
