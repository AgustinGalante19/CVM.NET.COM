using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CVM.NET.COM.Models;

namespace CVM.NET.COM.Controllers
{
    internal class Token
    {
        public async Task<string> ObtenerTokenAsync()
        {
            HttpClient request = new HttpClient();
            request.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

            var parameters = new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", "75c94fa0-4b06-4b83-bf5f-12eedca4e19d" },
                { "scope", "https://graph.microsoft.com/.default" },
                { "client_secret", "xO.8Q~1kQXjN75aaoHVPBxcangGNyt~aOtlFBcIU" }
            };

            var queryString = new FormUrlEncodedContent(parameters);

            HttpResponseMessage response = await request.PostAsync("https://login.microsoftonline.com/38fd41ea-2916-4c7a-8dc8-f2a898615eb1/oauth2/v2.0/token", queryString);

            string lstr_resContent = await response.Content.ReadAsStringAsync();

            TokenResponse lobj_response = JsonConvert.DeserializeObject<TokenResponse>(lstr_resContent);

            return lobj_response.access_token;
        }
    }
}
