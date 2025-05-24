using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() {
            CreateMap<EscolaDto, Escola>().ReverseMap();
            CreateMap<ExibirDto, Escola>().ReverseMap();
        }
    }
}
