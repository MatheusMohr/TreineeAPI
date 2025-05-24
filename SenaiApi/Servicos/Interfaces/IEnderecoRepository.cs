using SenaiApi.Entity;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEnderecoRepository
    {
        void Salvar(Endereco endereco);
        List<Endereco> PegarTodos();
        Task Remover(long id);
        Endereco ObterPorId(long id);
    }
}
