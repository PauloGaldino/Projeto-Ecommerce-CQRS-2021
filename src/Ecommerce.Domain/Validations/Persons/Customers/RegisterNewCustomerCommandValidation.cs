using Ecommerce.Domain.Commands.Persons.Customers;

namespace Ecommerce.Domain.Validations.Persons.Customers
{
    public class RegisterNewCustomerCommandValidation : CustomerValidation<RegisterNewCustomerCommand>
    {
        public RegisterNewCustomerCommandValidation()
        {
            ValidateName();
            ValidateBirthDate();
            ValidateEmail();
        }
    }
}
