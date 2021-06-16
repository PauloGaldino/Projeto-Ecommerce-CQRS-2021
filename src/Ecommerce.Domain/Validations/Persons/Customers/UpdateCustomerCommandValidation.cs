using Ecommerce.Domain.Commands.Persons.Customers;

namespace Ecommerce.Domain.Validations.Persons.Customers
{
    public class UpdateCustomerCommandValidation : CustomerValidation<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateBirthDate();
            ValidateEmail();
        }
    }
}