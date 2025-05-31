using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repository.Interfaces
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly SenaiContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(SenaiContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public List<T> ObterTodos()
        {
            return _dbSet.ToList();
        }
    }
}
