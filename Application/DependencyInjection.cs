using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Application.Common.Behaviors;
using MediatR;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        service.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));


        service.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return service;
    }
}