using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repository.Interfaces
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly SenaiContext _context;
        public EscolaRepository(SenaiContext context) {
            _context = context;
        }

        public void Salvar(Escola escola)
        {
            if (escola.Id == 0)
                _context.Escola.Add(escola);
            else
                _context.Escola.Update(escola);
            _context.SaveChanges();
        }

        public Escola ObterPorId(long id)
        {
            return _context.Escola.FirstOrDefault(e => e.Id == id);
        }
        public List<Escola> PegarTodos()
        {
            return _context
                 .Escola
                .Include(c => c.Classes)
                .Include(c => c.Endereco)
                .Include(c => c.Professores)
                .ToList();
        }

        public async Task Remover(long id)
        {
            await _context.Escola.Where(c => c.Id == id).ExecuteDeleteAsync();
        }

    }
}
