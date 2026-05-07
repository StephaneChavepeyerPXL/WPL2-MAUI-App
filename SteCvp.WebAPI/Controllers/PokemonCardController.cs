using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SteCvp.Application.Services;

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

            return Ok(pokemonCards);
        }
    }
}
