using AutoMapper;
using SenaiApi.Context;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interfaces;
using Newtonsoft.Json;


namespace SenaiApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddNewtonsoftJson(option => option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)   ;
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SenaiContext>();
            builder.Services.AddScoped<IEscolaService, EscolaService>();
            builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();
            builder.Services.AddScoped<IEnderecoService, EnderecoService>();
            builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
            builder.Services.AddScoped<IProfessorService, ProfessorService>();
            builder.Services.AddScoped<IClasseService, ClasseService>();
            builder.Services.AddScoped<IClasseRepository, ClasseRepository>();
            builder.Services.AddScoped<IAlunoService, AlunoService>();
            builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

            MapperConfiguration mapperConfiguration = new(mapperConfig => { mapperConfig.AddMaps(new[] { "SenaiApi" });  });
            builder.Services.AddSingleton(mapperConfiguration.CreateMapper());

            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
