using SenaiApi.Entity;
using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class ProfessorDto
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public long EscolaId { get; set; }
    }
}
    