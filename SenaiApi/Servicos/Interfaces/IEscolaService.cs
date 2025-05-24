using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEscolaService
    {
        void Salvar(EscolaDto escola);
        List<ExibirDto> BuscarTodos();
        Task Remover(long id);
        void Editar(ExibirDto model);
    }
}
