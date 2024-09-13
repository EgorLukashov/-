using System.ComponentModel.DataAnnotations;

namespace Турнирная_сетка.Entities
{
    public class Round
    {
        [Required]
        public int Id { get; set; }
        public int RoundNumber { get; set; }
        public List<Match>? Matches { get; set; }
    }
}
