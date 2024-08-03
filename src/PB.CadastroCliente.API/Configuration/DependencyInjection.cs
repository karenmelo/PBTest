using PB.CadastroCliente.API.Data;
using PB.Core.Mediator;

namespace PB.CadastroCliente.API.Configuration;

public static class DependencyInjection
{
    public static void RegistrarServicos(this IServiceCollection services)
    {
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<IMediatorHandler, MediatorHandler>();


        services.AddScoped<ClienteContext>();
    }

}
