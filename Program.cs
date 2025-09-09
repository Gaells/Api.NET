using Microsoft.EntityFrameworkCore;
using ApiWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext
builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseInMemoryDatabase("ProductsDb"));

// Adicionar o suporte a Controllers
builder.Services.AddControllers();

// Adicionar os serviços do SWASHBUCKLE para gerar a documentação E a INTERFACE
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Este método agora será encontrado!

var app = builder.Build();

// Habilitar a interface do Swagger em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapear os Controllers para que as rotas funcionem
app.MapControllers();

app.Run();