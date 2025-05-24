using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEnderecoService
    {
        void Salvar(EnderecoDto enderecoDto);
        List<ExibirEnderecoDto> BuscarTodos();
        Task Remover(long id);
        void Editar(ExibirEnderecoDto endereco);
    }
}
