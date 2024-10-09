using Microsoft.EntityFrameworkCore;
using UserDemo.Core.Interface;
using UserDemo.Infrastructure.Data;
using UserDemo.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database
builder.Services.AddDbContext<UserDemoContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("UserDemo")));

builder.Services.AddScoped<IUserRepository,UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapGet("/users", (IUserRepository userRepository) =>
{
    return userRepository.GetAllUsers();
});


app.Run();
