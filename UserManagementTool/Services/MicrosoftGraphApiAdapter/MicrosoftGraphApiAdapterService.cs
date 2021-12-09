﻿using Newtonsoft.Json;
using Services.TenantConfiguration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UserManagementTool.Services.Configuration;

namespace UserManagementTool.Services.MicrosoftGraphApiAdapter
{
    public class MicrosoftGraphApiAdapterService : IMicrosftGraphApiAdapterService
    {
        private string Credentials { get; set; }
        private string DirectoryId { get; set; }
        private string Scope { get; set; }

        public MicrosoftGraphApiAdapterService(IConfigurationService configurationService)
        {
            var id = configurationService.GraphApiClientId();
            var secret = configurationService.GraphApiClientSecret();

            Credentials = $"{id}:{secret}";
            DirectoryId = configurationService.GraphApiDirectoryId();
            Scope = configurationService.GraphApiScope();
        }

        public MicrosoftGraphApiResponse Ping(TenantConfiguration configuration)
        {
            var credentials = $"{configuration.ClientId}:{configuration.ClientSecret}";
            var response = GetAccessTokenAsync(credentials, configuration.DirectoryId, Scope);
            var result = response.Result;
            bool success = false;
            if (result != null && result.Validate())
            {
                success = true;
            }

            return new MicrosoftGraphApiResponse
            {
                Success = success
            };
        }

        public MicrosoftGraphApiResponse CreateUser(Dictionary<string, object> attributes)
        {
            throw new NotImplementedException();
        }

        public MicrosoftGraphApiResponse DeleteUser(string objectId)
        {
            throw new NotImplementedException();
        }

        public MicrosoftGraphApiResponse ReadUser(string objectId)
        {
            throw new NotImplementedException();
        }

        public MicrosoftGraphApiResponse UpdateUser(string objectId, Dictionary<string, object> attributes)
        {
            throw new NotImplementedException();
        }

        private async Task<AccessToken> GetAccessTokenAsync()
        {
            return await GetAccessTokenAsync(Credentials, DirectoryId, Scope);
        }

        private async Task<AccessToken> GetAccessTokenAsync(string credentials, string directoryId, string scope)
        {
            using (var client = new HttpClient())
            {
                // Set up headers
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

                // Set up form params
                List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>>();
                requestData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                requestData.Add(new KeyValuePair<string, string>("scope", scope));
                FormUrlEncodedContent requestBody = new FormUrlEncodedContent(requestData);

                // Make request
                var request = await client.PostAsync($"https://login.microsoftonline.com/{directoryId}/oauth2/v2.0/token", requestBody);

                // Get response
                var response = await request.Content.ReadAsStringAsync();

                // Read into AccessToken
                AccessToken token = JsonConvert.DeserializeObject<AccessToken>(response);

                return token;
            }
        }
    }
}
