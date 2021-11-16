using System;
using UserManagementTool.IO;
using UserManagementTool.Services.Messaging;

namespace UserManagementTool.App
{
    public class Application : IApplication
    {
        private IMessagingService MessagingService { get; }
        private IUserInputManager UserInputManager { get; }

        public Application(IMessagingService messagingService, IUserInputManager userInputManager)
        {
            MessagingService = messagingService;
            UserInputManager = userInputManager;
        }


        public void Run()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(MessagingService.AppVersionPrefix() + MessagingService.AppVersion() + MessagingService.AppVersionPrefix());
            Console.WriteLine();
            Console.WriteLine(MessagingService.Greeting());
            Console.WriteLine();
            while (true)
            {
                Console.Write(MessagingService.NewOpChars());

                // Prepare the input
                var input = Console.ReadLine();
                var args = input.Split(" ");

                // Handle the input
                var result = UserInputManager.Handle(args);

                // Print result
                Console.WriteLine();
                Console.WriteLine(result.Result);
                Console.WriteLine();
            }
            
        }
    }

}
