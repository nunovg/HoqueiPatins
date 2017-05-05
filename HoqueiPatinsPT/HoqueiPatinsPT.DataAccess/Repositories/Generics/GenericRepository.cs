using System;
using System.Data.Entity;
using System.Linq;

namespace HoqueiPatinsPT.DataAccess.Repositories.Generics
{
    public class GenericRepository<T>
        where T : class
    {
        DatabaseContext dbContext;
        DbSet<T> dbSet;

        public GenericRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet.AsQueryable();
        }

        public T GetById(Guid entityId)
        {
            return this.dbSet.Find(entityId);
        }

        public void Add(T entity)
        {
            this.dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Guid entityId)
        {
            T entity = this.dbSet.Find(entityId);
            this.dbSet.Remove(entity);
        }

        public void Delete(T entity)
        {
            if (dbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
    }
}
