using HoqueiPatinsPT.DataAccess.Models;
using HoqueiPatinsPT.DataAccess.Repositories.Generics;

namespace HoqueiPatinsPT.DataAccess.Repositories
{
    public class TeamsRepository : GenericRepository<Team>
    {
        private DatabaseContext dbContext;

        public TeamsRepository(DatabaseContext dbContext)
            : base(dbContext)
        {
        }
    }
}
