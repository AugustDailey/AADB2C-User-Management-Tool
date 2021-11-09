using System;
using System.Collections.Generic;
using System.Text;
using UserManagementTool.Services;
using UserManagementTool.Services.MicrosoftGraphApiAdapter;

namespace UserManagementTool.Command
{
    public class UpdateUserCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosftGraphApiAdapterService { get; }

        private string ObjectId { get; set; }
        private Dictionary<string, object> UserAttributes { get; set; }

        public UpdateUserCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, string objectId, 
            Dictionary<string, object> attributes)
        {
            MicrosftGraphApiAdapterService = microsftGraphApiAdapterService;

            ObjectId = objectId;
            UserAttributes = attributes;
        }

        public CommandResult Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(ObjectId) && UserAttributes.Keys.Count > 0;
        }
    }
}
