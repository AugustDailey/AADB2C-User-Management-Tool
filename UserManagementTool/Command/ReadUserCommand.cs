using UserManagementTool.Services.MicrosoftGraphApiAdapter;

namespace UserManagementTool.Command
{
    public class ReadUserCommand : ICommand
    {
        private IMicrosftGraphApiAdapterService MicrosftGraphApiAdapterService { get; }

        private string ObjectId { get; set; }

        public ReadUserCommand(IMicrosftGraphApiAdapterService microsftGraphApiAdapterService, string objectId)
        {
            MicrosftGraphApiAdapterService = microsftGraphApiAdapterService;

            ObjectId = objectId;
        }

        public CommandResult Execute()
        {
            return new CommandResult()
            {
                Result = "Successfully read user"
            };
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(ObjectId);
        }
    }
}
