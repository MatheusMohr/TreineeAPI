using System.ComponentModel.DataAnnotations;
using SenaiApi.Entidades;

namespace SenaiApi.Entity
{
    public class Escola : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Nome {  get; set; }
        public Endereco Endereco { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Classe> Classes {  get; set; }
    }
}
