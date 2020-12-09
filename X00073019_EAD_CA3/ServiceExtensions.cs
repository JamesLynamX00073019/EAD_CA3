using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace EADCA3
{
    public static class ServiceExtensions
    {

        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
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
