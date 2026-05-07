using SteCvp.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SteCvp.Application.Interfaces;
using SteCvp.Domain.Entities;

namespace SteCvp.Infrastructure.Repositories
{
    public class PokemonCardRepository : Repository, IPokemonCardRepository
    {
        public PokemonCardRepository(DbConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> AddAsync(PokemonCard pokemonCard)
        {
            using var connection = _connectionFactory.CreateConnection();

            string sql = "INSERT INTO dbo.PokemonCards (Name, SetName, Rarity, EstimatedValue, PhotoUrl) " +
                         "VALUES (@Name, @SetName, @Rarity, @EstimatedValue, @PhotoUrl); " +
                         "SELECT CAST(SCOPE_IDENTITY() as int)";

            return await connection.ExecuteScalarAsync<int>(sql, pokemonCard);
        }

        public async Task<IEnumerable<PokemonCard>> GetAllAsync()
        {
            using var connection = _connectionFactory.CreateConnection();

            string sql = "SELECT * FROM dbo.PokemonCards";

            return await connection.QueryAsync<PokemonCard>(sql);
        }
    }
}
