namespace SenaiApi.Servicos.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> ObterTodos();
    }
}
