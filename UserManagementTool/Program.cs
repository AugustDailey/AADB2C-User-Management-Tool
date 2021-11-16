using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using UserManagementTool.App;
using UserManagementTool.IO;
using UserManagementTool.Services.Configuration;
using UserManagementTool.Services.Messaging;
using UserManagementTool.Services.MicrosoftGraphApiAdapter;

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

            serviceCollection.AddSingleton<IConfigurationService, ConfigurationService>();
            serviceCollection.AddSingleton<IUserInputManager, UserInputManager>();
            serviceCollection.AddSingleton<ICommandBuilder, CommandBuilder>();
            serviceCollection.AddSingleton<IMicrosftGraphApiAdapterService, MicrosoftGraphApiAdapterService>();
            serviceCollection.AddSingleton<IMessagingService, MessagingService>();

            // Build and return provider
            return serviceCollection.BuildServiceProvider();

        }
    }
}
