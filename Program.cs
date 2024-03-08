using Cadastro_Cliente_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Cadastro_Cliente_Api.Models;
using Cadastro_Cliente_Api.Data.EFcore;
using Cadastro_Cliente_Api.Service;

var builder = WebApplication.CreateBuilder(args);
var conn = builder.Configuration.GetConnectionString("CadastroConn");
// Add services to the container.
builder.Services.AddDbContext<CadastroClienteContext>(opts =>
{
    opts.UseSqlServer(conn);
});

builder.Services.AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<CadastroClienteContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IUsuarioDao, UsuarioDao>();
builder.Services.AddScoped<TokenService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
