using Ecommerce.Domain.Commands.Persons.Customers;

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
