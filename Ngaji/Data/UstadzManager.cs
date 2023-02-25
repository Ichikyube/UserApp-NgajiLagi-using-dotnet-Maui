using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Ngaji.Data
{

    public static class UstadzManager
    {
        static readonly string BaseAddress = "https://services-dev.ngajilagi.com";
        static readonly string Url = $"{BaseAddress}/user";

        static HttpClient client;

        private static async Task<HttpClient> GetClient()
        {
            if (client != null) return null;

            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla / 5.0");

            return client;
        }

        public static async Task<IEnumerable<Ustadz>> GetAll()
        {
            HttpClient client = await GetClient();
            HttpResponseMessage response = await client.GetAsync(Url);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                var json = await response.Content.ReadAsStringAsync();
                var r = JsonConvert.DeserializeObject<ErrorValidation>(json);
                throw new Exception(r.ErrorMessage);
            }
            else
            {
                Ustadz ustadzResult = JsonConvert.DeserializeObject<Ustadz>(result);
                return (IEnumerable<Ustadz>)ustadzResult;
            }
        }

    }
    public class ErrorValidation
    {
        public string ErrorMessage { get; set; }
    }

}
