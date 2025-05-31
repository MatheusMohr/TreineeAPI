using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Mappers
{
    public class ProfessorMapper : Profile
    {
        public ProfessorMapper()
        {
            CreateMap<ProfessorDto, Professor>().ReverseMap();
            CreateMap<ExibirProfessorDto, Professor>().ReverseMap();
            CreateMap<EditarProfessorDto, Professor>().ReverseMap();
        }
    }
}
