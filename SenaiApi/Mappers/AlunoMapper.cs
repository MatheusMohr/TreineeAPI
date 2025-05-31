using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Mappers
{
    public class AlunoMapper : Profile
    {
        public AlunoMapper()
        {
            CreateMap<AlunoDto, Aluno>().ReverseMap();
            CreateMap<ExibirAlunoDto, Aluno>().ReverseMap();
            CreateMap<EditarAlunoDto, Aluno>().ReverseMap();
        }
    }
}
