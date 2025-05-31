using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repository.Interfaces
{
    public class ClasseRepository : IClasseRepository
    {
        private readonly SenaiContext _context;
        public ClasseRepository(SenaiContext context)
        {
            _context = context;
        }

        public void SalvarClasse(Classe classe)
        {
            if (classe.Id == 0)
                _context.Classe.Add(classe);
            else
                _context.Classe.Update(classe);
            _context.SaveChanges();
        }

        public Classe ObterPorId(long id)
        {
            return _context
                .Classe
                .Include(c => c.Escola)
                .FirstOrDefault(e => e.Id == id);
        }
        public List<Classe> PegarTodos()
        {
            return _context.Classe
                .Include(c => c.Alunos).ToList();
        }

        public async Task RemoverClasse(long id)
        {
            await _context.Classe.Where(c => c.Id == id).ExecuteDeleteAsync();
        }
    }
}
