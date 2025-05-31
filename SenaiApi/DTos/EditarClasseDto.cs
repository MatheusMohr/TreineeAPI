using SenaiApi.Entidades.Enums;

namespace SenaiApi.DTos
{
    public class EditarClasseDto
    {
        public long Id { get; set; }
        public SerieEnum Serie { get; set; }
        public long ProfessorId { get; set; }
    }
}
