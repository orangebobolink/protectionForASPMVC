using Microsoft.EntityFrameworkCore;
using prot.Models;

namespace prot.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Match> Matchs { get; set; }

        public ApplicationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=protmvc;Trusted_Connection=True;");
        }
    }
}
