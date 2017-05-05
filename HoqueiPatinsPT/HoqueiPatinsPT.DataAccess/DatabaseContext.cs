using HoqueiPatinsPT.DataAccess.Mappings;
using HoqueiPatinsPT.DataAccess.Models;
using System.Data.Entity;

namespace HoqueiPatinsPT.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        public DatabaseContext() : base("HoqueiPatinsPT")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeamMap());
            modelBuilder.Configurations.Add(new MatchMap());
        }
    }
}
