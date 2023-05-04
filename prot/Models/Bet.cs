using System.ComponentModel.DataAnnotations;

namespace prot.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int SumOfBet { get; set; }
        public string Command { get; set; } = string.Empty;
    }
}
