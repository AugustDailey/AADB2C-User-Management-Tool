using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using UserManagementTool.App;

namespace UserManagementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = ConfigureServices();

            var app = provider.GetService<IApplication>();
            app.Run();
        }

        static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging();

            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            // Add binded services
            serviceCollection.AddSingleton<IConfiguration>(configuration);
            serviceCollection.AddScoped<IApplication, Application>();

            // Build and return provider
            return serviceCollection.BuildServiceProvider();

        }
    }
}
