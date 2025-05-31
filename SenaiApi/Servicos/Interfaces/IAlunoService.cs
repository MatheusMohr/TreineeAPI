using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IAlunoService
    {
        void Salvar(AlunoDto alunoDto);
        void Editar(EditarAlunoDto model);
        List<ExibirAlunoDto> BuscarTodos();
        Task Remover(long id);
    }
}
