using Api.Domain.Interfaces.Services.Cliente;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IClienteService, ClienteService> ();
        }
    }
}