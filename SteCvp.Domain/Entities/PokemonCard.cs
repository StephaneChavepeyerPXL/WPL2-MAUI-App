using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteCvp.Domain.Entities
{
    public class PokemonCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SetName { get; set; }
        public string Rarity { get; set; }
        public decimal EstimatedValue { get; set; }
        public string PhotoUrl { get; set; }
    }
}
