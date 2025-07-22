using Interview.Api.Features.GenreFeature.Interfaces;
using Interview.Api.Features.GenreFeature.Repository;
using Interview.Api.Features.MediaFeature.Interfaces;
using Interview.Api.Features.MediaFeature.Repsitory;
using Interview.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IApiContext, ApiContext>((opts) => { opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });
builder.Services.AddTransient<IGenreRepository, GenreRepository>();
builder.Services.AddTransient<IMediaRepository, MediaRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
