using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repository.Interfaces
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly SenaiContext _context;
        public AlunoRepository(SenaiContext context)
        {
            _context = context;
        }

        public void SalvarAluno(Aluno aluno)
        {
            if (aluno.Id == 0)
                _context.Aluno.Add(aluno);
            else
                _context.Aluno.Update(aluno);
            _context.SaveChanges();
        }

        public Aluno ObterPorId(long id)
        {
            return _context.Aluno.FirstOrDefault(e => e.Id == id);
        }
        public List<Aluno> PegarTodos()
        {
            return _context.Aluno.ToList();
        }

        public async Task RemoverAluno(long id)
        {
            await _context.Aluno.Where(c => c.Id == id).ExecuteDeleteAsync();
        }
    }
}
