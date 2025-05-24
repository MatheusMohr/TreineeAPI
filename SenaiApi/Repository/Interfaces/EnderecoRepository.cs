using Microsoft.EntityFrameworkCore;
using SenaiApi.Context;
using SenaiApi.Entity;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repository.Interfaces
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly SenaiContext _context;
        public EnderecoRepository(SenaiContext context)
        {
            _context = context;
        }

        public void Salvar(Endereco endereco)
        {
            if (endereco.Id == 0)
                _context.Endereco.Add(endereco);
            else
                _context.Endereco.Update(endereco);
            _context.SaveChanges();
        }

        public Endereco ObterPorId(long id)
        {
            return _context.Endereco.FirstOrDefault(e => e.Id == id);
        }
        public List<Endereco> PegarTodos()
        {
            return _context.Endereco.ToList();
        }

        public async Task Remover(long id)
        {
            await _context.Endereco.Where(c => c.Id == id).ExecuteDeleteAsync();
        }
    }
}
