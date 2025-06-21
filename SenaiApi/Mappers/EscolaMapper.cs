using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() {
            CreateMap<EscolaDto, Escola>().ReverseMap();
            CreateMap<ExibirEscolaDto, Escola>().ReverseMap();
            CreateMap<EditarEscolaDto, Escola>().ReverseMap();
            CreateMap<EditarEnderecoDto, Endereco>().ReverseMap();
        }
    }
}
