using Newtonsoft.Json;

using SnackMindAPI.Models;

using System;
using System.Configuration;
using System.Data.Entity.Infrastructure.Design;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SnackMindAPI.ApiClient
{
    public class SmApiClient
    {
        private readonly HttpClient _httpClient;
        public SmApiClient()
        {
            var baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new InvalidOperationException("API base URL is not configured in app settings.");
            }
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }
        public async Task<TResponse> Get<TResponse>(string endPoint)
        {
            using (var response = await _httpClient.GetAsync(endPoint))
            {
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(content);
            }
        }
        public async Task<TResponse> Post<TResponse, TRequest>(string endPoint, TRequest data)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json"))
            {
                using (var response = await _httpClient.PostAsync(endPoint, content))
                {
                    response.EnsureSuccessStatusCode();
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TResponse>(responseContent);
                }
            }
        }
        public async Task<TResponse> PutAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(endpoint, jsonContent);
            Debug.WriteLine("uyarı : " + jsonContent);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(json);
        }

    }
}