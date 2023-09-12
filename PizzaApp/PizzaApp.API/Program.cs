using Microsoft.EntityFrameworkCore;
using PizzaApp.Application.Services;
using PizzaApp.Application.Services.Interfaces;
using PizzaApp.DataAccess;
using PizzaApp.DataAccess.Repositories;
using PizzaApp.DataAccess.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<DatabaseContext>(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration["Database:ConnectionString"]);
});

// Configure DatabaseContext

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
