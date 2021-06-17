using Ecommerce.Domain.Interfaces.UoW;
using Ecommerce.Infra.Data.Contexts;

namespace Ecommerce.Infra.Data.UoW
{
    public class UintOfWork : IUnitOfWork
    {
        private readonly EcommerceDbContext _context;

        public UintOfWork(EcommerceDbContext context)
        {
            _context = context;
        }
        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
