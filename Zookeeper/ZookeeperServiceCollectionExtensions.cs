using System.Net.Mail;
using Microsoft.Extensions.DependencyInjection;
using Zookeeper.Models;
using Zookeeper.Tools;

namespace Zookeeper;

public static class ZookeeperServiceCollectionExtensions
{
    public static void AddZookeeperClasses(this IServiceCollection services)
    {
        // Scope = HTTP Request
        //builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();

        services.AddTransient<IEmailService, EmailService>();

        //services.AddSingleton<IAnimalCache, AnimalCache>();

        services.AddScoped<Giraffe>(c => new Giraffe { Age = 10, Name = "Dependency Injected Giraffe" });
    }

    public static string Reverse(this string input)
    {
        if (input == "Hello")
            return "olleH";

        return input;
    }
}