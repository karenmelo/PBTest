using Microsoft.EntityFrameworkCore;
using PB.CadastroCliente.API.Data;
using System.Reflection;

namespace PB.CadastroCliente.API.Configuration;

public static class ApiConfiguration
{
    public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ClienteContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DbCliente"));
        });

        services.AddDbContext<ClienteContext>();

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddCors(options =>
        {

            options.AddPolicy("Geral",
                builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
        });
    }


    public static void UseApiConfiguration(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }
}
