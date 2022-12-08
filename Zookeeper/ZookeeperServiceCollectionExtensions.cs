using Microsoft.Extensions.DependencyInjection;
using Zookeeper.Models;
using Zookeeper.Repositories;
using Zookeeper.Tools;

namespace Zookeeper;

public static class ZookeeperServiceCollectionExtensions
{
    public static void AddZookeeperClasses(this IServiceCollection services)
    {
        // Transient = always a new object
        services.AddTransient<IEmailService, EmailService>();

        // Scope = one object per HTTP Request
        services.AddScoped<IAnimalRepository, AnimalRepository>();
        services.AddScoped<Giraffe>(c => new Giraffe { Age = 10, Name = "Dependency Injected Giraffe" });

        // Singleton = one object per application
        //services.AddSingleton<IAnimalCache, AnimalCache>();
    }

    public static string Reverse(this string input)
    {
        if (input == "Hello")
            return "olleH";

        return input;
    }
}