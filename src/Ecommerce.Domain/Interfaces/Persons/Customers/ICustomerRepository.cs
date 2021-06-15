using Ecommerce.Domain.Models.Persons.Customers;

namespace Ecommerce.Domain.Interfaces.Persons.Customers
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByEmail(string email);
    }
}
