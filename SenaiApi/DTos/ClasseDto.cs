using SenaiApi.Entidades.Enums;
using SenaiApi.Entity;

namespace SenaiApi.DTos
{
    public class ClasseDto
    {
        public SerieEnum Serie { get; set; }
        public long EscolaId { get; set; }
        public long ProfessorId { get; set; }
    }
}
