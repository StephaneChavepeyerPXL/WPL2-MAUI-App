using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteCvp.Application.Interfaces;
using SteCvp.Domain.Entities;

namespace SteCvp.Application.Services
{
    public class PokemonCardService
    {
        private readonly IPokemonCardRepository _pokemonCardRepository;

        public PokemonCardService(IPokemonCardRepository pokemonCardRepository)
        {
            _pokemonCardRepository = pokemonCardRepository;
        }

        public Task<IEnumerable<PokemonCard>> GetAllPokemonCards()
        {
            return _pokemonCardRepository.GetAllAsync();
        }

        public Task<int> AddPokemonCard(PokemonCard pokemoncard)
        {
            return _pokemonCardRepository.AddAsync(pokemoncard);
        }
    }
}
