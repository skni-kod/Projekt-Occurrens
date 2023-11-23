using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using NLog.Web;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Middleware;
using occurrensBackend.Models.RegisterModels;
using occurrensBackend.Models.RegisterModels.Validators;
using occurrensBackend.Services.AccountService;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Host.UseNLog();

builder.Services.AddControllers().AddFluentValidation();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ErrorHandlingMiddleware>();


builder.Services.AddScoped<DatabaseDbContext>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IRegisterService, RegisterService>();

builder.Services.AddScoped<IPasswordHasher<Doctor>, PasswordHasher<Doctor>>();

builder.Services.AddScoped<IValidator<RegisterDoctorDto>, RegisterDoctorDtoValidator>();


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


app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseAuthentication();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
