using Microsoft.EntityFrameworkCore;
using Mtgsets.Data;

var builder = WebApplication.CreateBuilder(args);
// https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=windows
var connectionString = builder.Configuration["ConnectionString"];

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MtgsetsContext>(opt =>
    opt.UseNpgsql(connectionString));
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
