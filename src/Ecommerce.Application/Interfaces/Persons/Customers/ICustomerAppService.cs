using Ecommerce.Application.EventSourcedNormalizers.Persons.Customers;
using Ecommerce.Application.ViewModels.Persons.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interfaces.Persons.Customers
{
    public interface ICustomerAppService : IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(Guid id);
        void Update(CustomerViewModel customerViewModel);
        void Remove(Guid id);
        IList<CustomerHistoryData> GetAllHistory(Guid id);
    }
}
