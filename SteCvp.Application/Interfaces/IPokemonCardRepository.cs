using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteCvp.Domain.Entities;

namespace SteCvp.Application.Interfaces
{
    public interface IPokemonCardRepository
    {
        Task<IEnumerable<PokemonCard>> GetAllAsync();
    }
}
