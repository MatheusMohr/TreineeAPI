using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class ExibirProfessorDto
    {
        [Required]
        [MaxLength(60)]
        public long Id { get; set; }
        public string Nome { get; set; }
        public long EscolaId { get; set; }
    }
}
