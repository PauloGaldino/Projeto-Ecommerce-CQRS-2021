using Ecommerce.Domain.Validations.Persons.Products;

namespace Ecommerce.Domain.Commands.Products
{
    public class RegisterNewProductCommand : ProductCommand
    {
        public RegisterNewProductCommand(string name, decimal value, bool state)
        {
            Name = name;
            Value = value;
            State = state;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewProductCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
