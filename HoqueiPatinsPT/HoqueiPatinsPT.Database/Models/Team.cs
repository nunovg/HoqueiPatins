using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HoqueiPatinsPT.Database.Models
{
    public class Team
    {
        [Key]
        public Guid PKID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Match> MatchesAsHomeTeam { get; set; }
        public virtual ICollection<Match> MatchesAsAwayTeam { get; set; }
    }
}
