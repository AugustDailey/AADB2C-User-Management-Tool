using System;
using UserManagementTool.Services.Messaging;

namespace UserManagementTool.App
{
    public class Application : IApplication
    {
        private IMessagingService MessagingService { get; }
        public Application(IMessagingService messagingService)
        {
            MessagingService = messagingService;
        }


        public void Run()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(MessagingService.AppVersionPrefix() + MessagingService.AppVersion() + MessagingService.AppVersionPrefix());
            Console.WriteLine();
            Console.WriteLine(MessagingService.Greeting());
            Console.WriteLine();
            Console.Write(MessagingService.NewOpChars());
            Console.ReadLine();
        }
    }

}
