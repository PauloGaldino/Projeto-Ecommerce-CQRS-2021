using Ecommerce.Domain.Interfaces;
using Ecommerce.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ecommerce.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly EcommerceDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(EcommerceDbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            Db.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            Db.Update(obj);
        }
        public void Remove(Guid id)
        {
            Db.Remove(DbSet.Find(id));
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
