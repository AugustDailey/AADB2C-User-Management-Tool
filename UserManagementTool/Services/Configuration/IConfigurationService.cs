namespace UserManagementTool.Services.Configuration
{
    public interface IConfigurationService
    {
        string GraphApiClientId();
        string GraphApiClientSecret();
        string GraphApiDirectoryId();
        string GraphApiScope();
        string TenantConfigurationDirectory();
        string TenantConfigurationDelimiter();
    }
}
