using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repository.Interfaces
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly SenaiContext _context;
        public ProfessorRepository(SenaiContext context)
        {
            _context = context;
        }

        public void Salvar(Professor professor)
        {
            if (professor.Id == 0)
                _context.Professor.Add(professor);
            else
                _context.Professor.Update(professor);
            _context.SaveChanges();
        }

        public Professor ObterPorId(long id)
        {
            return _context.Professor.FirstOrDefault(e => e.Id == id);
        }
        public List<Professor> PegarTodos()
        {
            return _context.Professor.ToList();
        }

        public async Task Remover(long id)
        {
            await _context.Professor.Where(c => c.Id == id).ExecuteDeleteAsync();
        }
    }
}
