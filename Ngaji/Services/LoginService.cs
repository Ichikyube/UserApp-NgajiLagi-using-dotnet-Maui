using Newtonsoft.Json;
using Ngaji.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngaji.Services
{
    public class LoginService : ILoginRepo
    {
        public async Task<LoginRequest> Login(string userName, string password)
        {
            var userInfo = new List<LoginRequest>();
            var client = new HttpClient();

            var url = "https://minhaapi.net/api/userInfos/LoginUser/" + userName + "/" + password;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                userInfo = JsonConvert.DeserializeObject<List<LoginRequest>>(content);

                return await Task.FromResult(userInfo.FirstOrDefault());
            }
            else
            {
                return null;
            }
        }
    }
}
