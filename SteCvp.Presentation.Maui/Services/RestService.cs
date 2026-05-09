using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteCvp.Domain.Entities;

namespace SteCvp.Presentation.Maui.Services
{
    public class RestService
    {
        private readonly HttpClient _httpClient;

        public RestService()
        {
            _httpClient = new HttpClient();
        }

        private const string REST_URL = "https://g80zrzgj-7082.euw.devtunnels.ms/api/PokemonCard";

        public async Task<HttpResponseMessage> GetPokemonCardsAsync()
        {
            var response = await _httpClient.GetAsync(REST_URL);

            return response;
        }
    }
}
