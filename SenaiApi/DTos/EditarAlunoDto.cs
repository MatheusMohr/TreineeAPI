using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class EditarAlunoDto
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        [Required]
        [MaxLength(14)]
        public string CPF { get; set; }
        public long ClasseId { get; set; }
    }
}
