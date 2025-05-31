using AutoMapper;
using SenaiApi.Controllers;
using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Mappers
{
    public class ClasseMapper : Profile
    {
        public ClasseMapper()
        {
            CreateMap<ClasseDto, Classe>().ReverseMap();
            CreateMap<ExibirClasseDto, Classe>().ReverseMap();
            CreateMap<EditarClasseDto, Classe>().ReverseMap();
        }
    }
}
