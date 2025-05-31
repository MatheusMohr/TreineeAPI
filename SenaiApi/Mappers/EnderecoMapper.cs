using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entity;

namespace SenaiApi.Mappers
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
            CreateMap<EnderecoDto, Endereco>().ReverseMap();
            CreateMap<ExibirEnderecoDto, Endereco>().ReverseMap();
            CreateMap<EditarEnderecoDto, Endereco>().ReverseMap();
        }
    }
}
