using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SteCvp.Application.Services;
using SteCvp.Domain.Entities;

namespace SteCvp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonCardController : ControllerBase
    {
        private readonly PokemonCardService _pokemonCardService;

        public PokemonCardController(PokemonCardService pokemonCardService)
        {
            _pokemonCardService = pokemonCardService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pokemonCards = await _pokemonCardService.GetAllPokemonCardsAsync();

            var json = JsonConvert.SerializeObject(pokemonCards);

            return Ok(json);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PokemonCard pokemonCard)
        {
            int newId = await _pokemonCardService.AddPokemonCardAsync(pokemonCard);

            return Ok(newId);
        }
    }
}
