using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class EditarProfessorDto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long EscolaId { get; set; }
    }
}
