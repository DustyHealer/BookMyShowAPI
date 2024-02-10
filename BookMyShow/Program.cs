using BookMyShow.Models;
using BookMyShow.Repository;
using BookMyShow.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register the Db context classes
builder.Services.AddDbContext<BookMyShowContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("BookMyShowCS"))
);

// Register repo classes in the services
builder.Services.AddScoped<IActorRepository, ActorRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();

// Register repo classes in the services
builder.Services.AddScoped<IActorService, ActorService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IGenreService, GenreService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage(); // Exception handling for the api
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
