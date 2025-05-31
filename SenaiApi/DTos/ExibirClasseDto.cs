using SenaiApi.Entidades.Enums;
using SenaiApi.Entity;

namespace SenaiApi.DTos
{
    public class ExibirClasseDto
    {
        public long Id { get; set; }
        public SerieEnum Serie { get; set; }
        public List<AlunoDto> Alunos { get; set; }
        public long EscolaId { get; set; }
        public long ProfessorId { get; set; }
    }
}
