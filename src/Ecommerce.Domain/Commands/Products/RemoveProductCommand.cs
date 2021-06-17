using Ecommerce.Domain.Validations.Persons.Products;
using System;

namespace Ecommerce.Domain.Commands.Products
{
    public class RemoveProductCommand : ProductCommand
    {
        public RemoveProductCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveProductCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
