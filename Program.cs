using ApiClientes.Data;
using ApiClientes.Repositories;
using ApiClientes.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmpresaDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("EmpresaDB")));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<IClienteService, ClienteService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();