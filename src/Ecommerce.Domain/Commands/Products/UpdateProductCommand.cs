using Ecommerce.Domain.Validations.Persons.Products;
using System;

namespace Ecommerce.Domain.Commands.Products
{
    public class UpdateProductCommand : ProductCommand
    {
        public UpdateProductCommand(Guid id, string name, decimal value, bool state)
        {
            Id = id;
            Name = name;
            Value = value;
            State = state;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateProductCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
