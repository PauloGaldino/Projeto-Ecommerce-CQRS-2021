using System;
using System.Linq;

namespace Ecommerce.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        //CRUD
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(Guid id);

        //Pesquisa
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();

        //Outros
        int SaveChanges();
    }
}
