using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace EADCA3
{
    public static class ServiceExtensions
    {

        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            // Thanks to Ryan Deering for helping me with this, had trouble overcoming CORS
            // Had to include API key in request headers
            request.Headers.Add("x-api-key", "a3abe5e2-074d-45ff-bb4d-0699b802e03d");

            var response = await httpClient.SendAsync(request);
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            response.Headers.Add("x-api-key", "a3abe5e2-074d-45ff-bb4d-0699b802e03d");
            response.EnsureSuccessStatusCode();

            var responseBytes = await response.Content.ReadAsByteArrayAsync();

            
            return JsonSerializer.Deserialize<T>(responseBytes, new JsonSerializerOptions { });
        }
    }
}
