using SenaiApi.Entity;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IClasseRepository
    {
        void SalvarClasse(Classe classe);
        Classe ObterPorId(long id);
        List<Classe> PegarTodos();
        Task RemoverClasse(long id);
    }
}
