using Ecommerce.Domain.Interfaces.Persons.Customers;
using Ecommerce.Domain.Models.Persons.Customers;
using Ecommerce.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Ecommerce.Infra.Data.Repositories.Persons.Customers
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(EcommerceDbContext context) : base(context) { }
        public Customer GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}
