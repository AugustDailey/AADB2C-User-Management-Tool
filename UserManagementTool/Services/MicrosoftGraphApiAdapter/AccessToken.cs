using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementTool.Services.MicrosoftGraphApiAdapter
{
    public class AccessToken
    {
        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public long Expires_in { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(Access_token);
        }
    }
}
