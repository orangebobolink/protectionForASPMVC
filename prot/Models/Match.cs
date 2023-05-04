namespace prot.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string CommandOne { get; set; } = string.Empty;
        public string CommandTwo { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
