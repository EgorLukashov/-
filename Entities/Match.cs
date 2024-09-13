
using System.ComponentModel.DataAnnotations;

namespace Турнирная_сетка.Entities
{
    public class Match
    {
        [Required]
        public int Id { get; set; }

        public int? Team1Id { get; set; }  // ID первой команды
        public Team? Team1 { get; set; }   // Связь с первой командой

        public int? Team2Id { get; set; }  // ID второй команды
        public Team? Team2 { get; set; }   // Связь со второй командой

        public int? WinnerId { get; set; }  // ID победившей команды
        public Team? Winner { get; set; }   // Связь с победившей командой

        public DateTime MatchTime { get; set; }
        public string Status { get; set; } = "Scheduled";

        public int? RoundId { get; set; }  // Связь с раундом
        public Round? Round { get; set; }  // Связь с объектом Round
    }
}
