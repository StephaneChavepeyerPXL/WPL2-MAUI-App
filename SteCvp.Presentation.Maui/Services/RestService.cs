using Newtonsoft.Json;
using SteCvp.Domain.Entities;

namespace SteCvp.Presentation.Maui.Services
{
    public class RestService
    {
        private readonly HttpClient _httpClient;
        private const string OverrideBaseUrl = ""; // Optioneel: devtunnel link hier

        public RestService()
        {
            _httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(20)
            };
        }

        public async Task<IEnumerable<PokemonCard>> GetPokemonCardsAsync()
        {
            var endpoint = BuildPokemonCardsEndpoint();
            var response = await _httpClient.GetAsync(endpoint);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(
                    $"REST call failed ({(int)response.StatusCode}) on {endpoint}. Response: {content}");
            }

            return JsonConvert.DeserializeObject<IEnumerable<PokemonCard>>(content) ?? Enumerable.Empty<PokemonCard>();
        }

        public string GetCurrentEndpoint() => BuildPokemonCardsEndpoint();

        private static string BuildPokemonCardsEndpoint()
        {
            if (!string.IsNullOrWhiteSpace(OverrideBaseUrl))
            {
                return $"{OverrideBaseUrl.TrimEnd('/')}/api/PokemonCard";
            }

            var configuredBaseUrl = Environment.GetEnvironmentVariable("STE_CVP_API_BASE_URL");
            var baseUrl = !string.IsNullOrWhiteSpace(configuredBaseUrl)
                ? configuredBaseUrl.TrimEnd('/')
                : GetDefaultBaseUrl();

            return $"{baseUrl}/api/PokemonCard";
        }

        private static string GetDefaultBaseUrl()
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
                return "http://10.0.2.2:5028";

            return "http://localhost:5028";
        }
    }
}
