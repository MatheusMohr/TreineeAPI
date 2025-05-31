using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IClasseService
    {
        void Salvar(ClasseDto classeDto);
        void Editar(EditarClasseDto model);
        List<ExibirClasseDto> BuscarTodos();
        Task Remover(long id);

    }
}
