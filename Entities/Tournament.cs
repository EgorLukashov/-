
using System.ComponentModel.DataAnnotations;

namespace Турнирная_сетка.Entities
{
    public class Tournament
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Team>? Teams { get; set; }
        public List<Round>? Rounds { get; set; }
        public int CurrentRound { get; set; }
    }
}
