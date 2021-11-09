namespace UserManagementTool.IO
{
    public interface IUserInputManager
    {
        UserInputResult Handle(string[] input);
    }
}
