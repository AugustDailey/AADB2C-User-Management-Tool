using System;
using UserManagementTool.Command;
using UserManagementTool.IO;
using UserManagementTool.Services.Messaging;

namespace UserManagementTool.App
{
    public class Application : IApplication
    {
        private IMessagingService MessagingService { get; }
        private IUserInputManager UserInputManager { get; }

        private bool Running { get; set; }

        public Application(IMessagingService messagingService, IUserInputManager userInputManager)
        {
            MessagingService = messagingService;
            UserInputManager = userInputManager;

            Running = true;
        }


        public void Run()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(MessagingService.AppVersionPrefix() + MessagingService.AppVersion() + MessagingService.AppVersionPrefix());
            Console.WriteLine();
            Console.WriteLine(MessagingService.Greeting());
            Console.WriteLine();
            while (Running)
            {
                Console.Write(MessagingService.NewOpChars());

                // Prepare the input
                var input = Console.ReadLine();
                var args = input.Split(" ");

                // Handle the input
                var result = UserInputManager.Handle(args);

                switch(result.Action)
                {
                    case ResultAction.Print:
                        Print(result.Result);
                        break;

                    case ResultAction.Quit:
                        Quit();
                        break;

                    default:
                        break;
                }
            }
        }

        private void Print(string output)
        {
            // Print result
            Console.WriteLine();
            Console.WriteLine(output);
            Console.WriteLine();
        }

        private void Quit()
        {
            // Print result
            Console.WriteLine();
            Console.WriteLine("Application shutting down...");
            Console.WriteLine();
            Running = false;
        }
    }

}
