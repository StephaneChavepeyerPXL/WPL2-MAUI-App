using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteCvp.Domain.Entities;

namespace SteCvp.Presentation.Maui.Services
{
    public class RestService
    {
        private readonly HttpClient _httpClient;

        private const string REST_URL = "https://g80zrzgj-7082.euw.devtunnels.ms/api/PokemonCard";

        public RestService()
        {
            _httpClient = new HttpClient();
        }

        //public async Task<HttpResponseMessage> GetPokemonCardsAsync()
        //{
        //    var response = await _httpClient.GetAsync(REST_URL);

        //    return response;
        //}

        public async Task<IEnumerable<PokemonCard>> GetPokemonCardsAsync()
        {
            var response = await _httpClient.GetAsync(REST_URL); // Verstuurd een GET-verzoek naar de REST API

            var content = await response.Content.ReadAsStringAsync(); // Leest de inhoud van het antwoord als een string

            var pokemonCards = JsonConvert.DeserializeObject<IEnumerable<PokemonCard>>(content); // Deserialiseert de JSON-string naar een lijst van PokemonCard-objecten

            return pokemonCards;
        }
    }
}
