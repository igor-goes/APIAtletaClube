using AtletaClubeAPI.Controllers;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Atletas e Clubes",
        Version = "v1",
        Description = "API que fornece informações sobre atletas e clubes",
    });
});
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IBaseRepository<Atleta>, BaseRepository<Atleta>>();
builder.Services.AddScoped<BaseRepository<Clube>>(); builder.Services.AddScoped<IBaseRepository<Clube>, BaseRepository<Clube>>();
builder.Services.AddScoped<BaseRepository<Atleta>>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

