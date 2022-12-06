using CVM.NET.COM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CVM.NET.COM.Controllers
{
    internal class Test
    {
        public async Task<UserResponse> ObtenerUserAsync(string str_accesstoken)
        {
            HttpClient lobj_httpclient = new HttpClient();

            lobj_httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", str_accesstoken);

            HttpResponseMessage response = await lobj_httpclient.GetAsync("https://graph.microsoft.com/v1.0/users/17ef10eb-3a01-412a-84da-f6b76edb7b76");

            string lstr_resContent = await response.Content.ReadAsStringAsync();

            UserResponse lobj_user = JsonConvert.DeserializeObject<UserResponse>(lstr_resContent);
            
            return lobj_user;
        }
    }
}
