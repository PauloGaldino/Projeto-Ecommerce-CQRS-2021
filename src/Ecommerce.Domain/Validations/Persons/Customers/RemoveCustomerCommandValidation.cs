using Ecommerce.Domain.Commands.Persons.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Validations.Persons.Customers
{
    public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}
