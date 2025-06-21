namespace SenaiApi.DTos
{
    public class EditarEscolaDto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public EditarEnderecoDto? Endereco { get; set; }

    }
}
