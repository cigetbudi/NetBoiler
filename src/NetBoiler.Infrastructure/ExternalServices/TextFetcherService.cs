using System.Text.Json;
using Microsoft.Extensions.Configuration;
using NetBoiler.Application.Interfaces;

namespace NetBoiler.Infrastructure.ExternalServices
{
    public class TextFetcherService : ITextFetcher
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public TextFetcherService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task<string> FetchTextAsync()
        {
            var url = _config["ExternalApi:TextUrl"];
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var json = JsonDocument.Parse(content);
            return json.RootElement.GetProperty("text").GetString()!;
        }
    }
}