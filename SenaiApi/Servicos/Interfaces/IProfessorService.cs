using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IProfessorService
    {
        void Salvar(ProfessorDto professorDto);
        void Editar(EditarProfessorDto model);
        List<ExibirProfessorDto> BuscarTodos();
        Task Remover(long id);
    }
}
