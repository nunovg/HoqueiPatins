using HoqueiPatinsPT.DataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace HoqueiPatinsPT.DataAccess.Mappings
{
    public class TeamMap : EntityTypeConfiguration<Team>
    {
        public TeamMap()
        {
            this.HasKey(e => e.PKID);

            this.Property(e => e.Name)
                .HasColumnName(nameof(Team.Name));
        }
    }
}
