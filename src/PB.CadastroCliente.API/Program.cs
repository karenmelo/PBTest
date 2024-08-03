using PB.CadastroCliente.API.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.RegistrarServicos();






//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

app.UseApiConfiguration();

app.Run();
