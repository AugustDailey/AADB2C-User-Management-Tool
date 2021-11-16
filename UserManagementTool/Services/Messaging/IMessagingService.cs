namespace UserManagementTool.Services.Messaging
{
    public interface IMessagingService
    {
        public string AppVersion();
        public string AppVersionPrefix();
        public string Author();
        public string Farewell();
        public string Greeting();
        public string NewOpChars();

    }
}
