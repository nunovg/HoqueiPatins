using HoqueiPatinsPT.DataAccess.Models;
using HoqueiPatinsPT.DataAccess.Repositories;
using HoqueiPatinsPT.DataAccess.Repositories.Generics;
using System;

namespace HoqueiPatinsPT.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private DatabaseContext dbContext = new DatabaseContext();
        private TeamsRepository teamsRepository;
        private MatchesRepository matchesRepository;

        public TeamsRepository TeamsRepository
        {
            get
            {
                if (this.teamsRepository == null)
                {
                    this.teamsRepository = new TeamsRepository(dbContext);
                }
                return teamsRepository;
            }
        }

        public MatchesRepository MatchesRepository
        {
            get
            {
                if (this.matchesRepository == null)
                {
                    this.matchesRepository = new MatchesRepository(dbContext);
                }
                return matchesRepository;
            }
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
