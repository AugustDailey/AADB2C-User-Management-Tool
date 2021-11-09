using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Services.MicrosoftGraphApiAdapter
{
    public interface IMicrosftGraphApiAdapterService
    {
        MicrosoftGraphApiResponse CreateUser(Dictionary<string, object> attributes);
        MicrosoftGraphApiResponse ReadUser(string objectId);
        MicrosoftGraphApiResponse UpdateUser(string objectId, Dictionary<string, object> attributes);
        MicrosoftGraphApiResponse DeleteUser(string objectId);
        
    }
}
