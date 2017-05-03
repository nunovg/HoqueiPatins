using HoqueiPatinsPT.Database.Models;
using System.Data.Entity.ModelConfiguration;

namespace HoqueiPatinsPT.Database.Mappings
{
    public class MatchMap : EntityTypeConfiguration<Match>
    {
        public MatchMap()
        {
            this.HasKey(e => e.PKID);

            this.Property(e => e.HomeTeamId)
                .HasColumnName(nameof(Match.HomeTeamId));
            this.Property(e => e.AwayTeamId)
                .HasColumnName(nameof(Match.AwayTeamId));

            this.HasRequired(e => e.HomeTeam)
                .WithMany(e => e.MatchesAsHomeTeam)
                .HasForeignKey(e => e.HomeTeamId)
                .WillCascadeOnDelete(false);
            this.HasRequired(e => e.AwayTeam)
                .WithMany(e => e.MatchesAsAwayTeam)
                .HasForeignKey(e => e.AwayTeamId)
                .WillCascadeOnDelete(false);
        }
    }
}
