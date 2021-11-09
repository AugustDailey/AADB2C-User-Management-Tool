namespace UserManagementTool.Command
{
    public interface ICommand
    {
        bool IsValid();
        CommandResult Execute();
    }
}
