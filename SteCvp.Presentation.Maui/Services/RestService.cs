using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
