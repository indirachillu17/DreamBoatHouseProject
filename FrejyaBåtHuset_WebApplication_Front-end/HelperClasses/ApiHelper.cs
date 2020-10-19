using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebApplication_Front_end.HelperClasses
{
    public class ApiHelper
    {
        public async Task<T> GetCallApiAsync<T>(string Url)
        {
            HttpClient httpClient = new HttpClient();

            var responseMessage = await httpClient.GetAsync(Url);

            var response = await responseMessage.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(response))
                return JsonConvert.DeserializeObject<T>(response);

            return (default);
        }

        public async Task<T> PostCallApiAsync<T>(string Url, T data)
        {
            HttpClient httpClient = new HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var responseMessage = await httpClient.PostAsync(Url, stringContent);

            var response = await responseMessage.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(response))
                return JsonConvert.DeserializeObject<T>(response);

            return (default);
        }

        public async Task PutCallApiAsync<T>(string Url, T data)
        {
            HttpClient httpClient = new HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            await httpClient.PutAsync(Url, stringContent);
        }

        public async Task DeleteCallApiAsync<T>(string Url)
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(Url);
        }
    }
}
