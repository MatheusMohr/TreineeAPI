using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEscolaService
    {
        void Salvar(EscolaDto escola);
        List<ExibirEscolaDto> BuscarTodos();
        Task Remover(long id);
        void Editar(EditarEscolaDto model);
    }
}
