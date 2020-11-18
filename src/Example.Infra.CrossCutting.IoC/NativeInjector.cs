using Example.Application.Candidato.Services;
using Example.Application.Partido.Services;
using Example.Application.Example.Repository;
using Example.Application.Example.Services;
using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using Example.Domain.SeedWork;
using Example.Infra.Data.Repositories;
using Example.Infra.Data.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Infra.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void Setup(IServiceCollection services)
        {
            RegisterServices(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<INotification, Notification>();

            services.AddScoped<IExampleService, ExampleService>();
            services.AddScoped<IExampleRepository, ExampleRepository>();

            services.AddScoped<ICandidatoService, CandidatoService>();
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();

            services.AddScoped<IPartidoService, PartidoService>();
            services.AddScoped<IPartidoRepository, PartidoRepository>();


        }
    }
}
