using System.ComponentModel.DataAnnotations;
using SenaiApi.Entity;

namespace SenaiApi.DTos
{
    public class ExibirEscolaDto
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public long Id { get; set; }
        public EnderecoDto Endereco { get; set; }
        public List<ClasseDto> Classes { get; set; }
        public List<ExibirProfessorDto> Professores { get; set; }
    }
}
