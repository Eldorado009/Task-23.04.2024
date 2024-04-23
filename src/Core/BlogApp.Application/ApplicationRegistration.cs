using BlogApp.Application.Features.Commands.BlogCommands;
using BlogApp.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Application;

public static class ApplicationRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile).Assembly);
        services.AddMediatR(opt =>
        {
            opt.RegisterServicesFromAssembly(typeof(BlogPostRequest).Assembly);
        });
    }
}
