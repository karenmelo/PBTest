using PB.CadastroCliente.API.Configuration;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddApiConfiguration(builder.Configuration);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

app.UseApiConfiguration();

app.Run();
