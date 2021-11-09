using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Services.Messaging
{
    public class MessagingService : IMessagingService
    {
        // TODO: Change this to read from a file containing messaging
        public MessagingService()
        {

        }

        public string AppVersion()
        {
            return "AADB2C User Management Tool v0.1.0";
        }

        public string AppVersionPrefix()
        {
            return "***********************";
        }

        public string Author()
        {
            return "August Dailey";
        }

        public string Farewell()
        {
            return "Goodbye!";
        }

        public string Greeting()
        {
            return "Welcome to the AADB2C User Management Tool! You can use this application to manage your users hosted within Azure Active Directory B2C instances. This command line tool offers functionality such as creating, reading, modifying, and deleting users through different commands. Type \"--help\" to get a full list of available commands.";
        }

        public string NewOpChars()
        {
            return ">";
        }
    }
}
