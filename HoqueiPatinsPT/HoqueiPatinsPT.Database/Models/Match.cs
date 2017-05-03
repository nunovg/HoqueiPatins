using System;
using System.ComponentModel.DataAnnotations;

namespace HoqueiPatinsPT.Database.Models
{
    public class Match
    {
        [Key]
        public Guid PKID { get; set; }

        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
    }
}
