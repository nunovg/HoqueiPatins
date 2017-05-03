using HoqueiPatinsPT.Database.Mappings;
using HoqueiPatinsPT.Database.Models;
using System.Data.Entity;

namespace HoqueiPatinsPT.Database
{
    public class Context : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        public Context() : base("HoqueiPatinsPT")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeamMap());
            modelBuilder.Configurations.Add(new MatchMap());
        }
    }
}
