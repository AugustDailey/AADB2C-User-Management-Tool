using Services.TenantConfiguration;
using System.Collections.Generic;

namespace UserManagementTool.Services.MicrosoftGraphApiAdapter
{
    public interface IMicrosftGraphApiAdapterService
    {
        MicrosoftGraphApiResponse Ping(TenantConfiguration configuration);
        MicrosoftGraphApiResponse CreateUser(Dictionary<string, object> attributes);
        MicrosoftGraphApiResponse ReadUser(string objectId);
        MicrosoftGraphApiResponse UpdateUser(string objectId, Dictionary<string, object> attributes);
        MicrosoftGraphApiResponse DeleteUser(string objectId);
        
    }
}
