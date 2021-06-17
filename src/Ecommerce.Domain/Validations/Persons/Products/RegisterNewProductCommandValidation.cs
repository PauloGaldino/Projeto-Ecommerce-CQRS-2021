using Ecommerce.Domain.Commands.Products;

namespace Ecommerce.Domain.Validations.Persons.Products
{
    public class RegisterNewProductCommandValidation : ProductValidation<RegisterNewProductCommand>
    {
        public RegisterNewProductCommandValidation()
        {
            ValidateName();
            ValidateValue();
        }
    }
}
