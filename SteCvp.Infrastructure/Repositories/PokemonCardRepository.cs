using SteCvp.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteCvp.Application.Interfaces;
using SteCvp.Domain.Entities;

namespace SteCvp.Infrastructure.Repositories
{
    public class PokemonCardRepository : Repository, IPokemonCardRepository
    {
        public PokemonCardRepository(DbConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public Task<int> AddAsync(PokemonCard pokemonCard)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PokemonCard>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
