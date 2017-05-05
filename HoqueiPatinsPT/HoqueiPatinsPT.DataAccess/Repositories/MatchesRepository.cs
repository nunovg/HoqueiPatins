using HoqueiPatinsPT.DataAccess.Models;
using HoqueiPatinsPT.DataAccess.Repositories.Generics;

namespace HoqueiPatinsPT.DataAccess.Repositories
{
    public class MatchesRepository : GenericRepository<Match>
    {
        private DatabaseContext dbContext;

        public MatchesRepository(DatabaseContext dbContext)
            : base(dbContext)
        {
        }
    }
}
