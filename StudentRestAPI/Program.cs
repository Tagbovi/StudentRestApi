using Microsoft.EntityFrameworkCore;
using StudentRestAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Register services here
builder.Services.AddDbContext<StudentRestAPI.Models.AppDbContext> (options => options.UseNpgsql(
builder.Configuration.GetConnectionString("DBConnection")
));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();    


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


