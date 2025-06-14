using SenaiApi.DTos;
using SenaiApi.Entity;
using SenaiApi.Repository.Interfaces;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEscolaService
    {
        void Salvar(EditarEscolaDto model);
        List<ExibirEscolaDto> BuscarTodos();
        Escola PegarPorId(long id);
        Task Remover(long id);
        void Editar(EditarEscolaDto model);
    }
}
