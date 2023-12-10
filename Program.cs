using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using NLog.Web;
using occurrensBackend;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Middleware;
using occurrensBackend.Models.RegisterModels;
using occurrensBackend.Models.RegisterModels.Validators;
using occurrensBackend.Services.AccountService;
using occurrensBackend.Services.DoctorInformationsService;
using occurrensBackend.Services.ShowAllDoctorsService;
using occurrensBackend.Services.UserContextService;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Host.UseNLog();

builder.Services.AddControllers().AddFluentValidation();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var authenticationSettings = new AuthenticationSettings();
builder.Configuration.GetSection("Authentication").Bind(authenticationSettings);
builder.Services.AddSingleton(authenticationSettings);

builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = "Bearer";
    option.DefaultScheme = "Bearer";
    option.DefaultChallengeScheme = "Bearer";
}).AddJwtBearer(cfg =>
{
    cfg.RequireHttpsMetadata = false;
    cfg.SaveToken = true;
    cfg.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = authenticationSettings.JwtIssuer,
        ValidAudience = authenticationSettings.JwtIssuer,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey)),
    };
});




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ErrorHandlingMiddleware>();


builder.Services.AddScoped<DatabaseDbContext>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IRegisterService, RegisterService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IAboutDoctorService, AboutDoctorService>();
builder.Services.AddScoped<IShowAllDoctorsService, ShowAllDoctorsService>();
builder.Services.AddScoped<IUserContextService, UserContextService>();

builder.Services.AddScoped<IPasswordHasher<Doctor>, PasswordHasher<Doctor>>();
builder.Services.AddScoped<IPasswordHasher<Patient>, PasswordHasher<Patient>>();

builder.Services.AddScoped<IValidator<RegisterDoctorDto>, RegisterDoctorDtoValidator>();
builder.Services.AddScoped<IValidator<RegisterPatientDto>, RegisterPatientDtoValidator>();


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
