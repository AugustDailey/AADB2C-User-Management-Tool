namespace UserManagementTool.IO
{
    public class UserInputManager : IUserInputManager
    {
        private ICommandBuilder CommandBuilder { get; }
        public UserInputManager(ICommandBuilder commandBuidler)
        {
            CommandBuilder = commandBuidler;
        }


        public UserInputResult Handle(string[] input)
        {
            var command = CommandBuilder.Build(input);

            if (command.IsValid())
            {
                // TODO: Make this an error result
                return new UserInputResult();
            }
            var result = command.Execute();
            return new UserInputResult()
            {
                Result = result.Result
            };

        }
    }
}
