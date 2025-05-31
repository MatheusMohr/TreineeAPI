using System.ComponentModel.DataAnnotations;
using SenaiApi.Entity;

namespace SenaiApi.DTos
{
    public class EscolaDto
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
    }
}
    