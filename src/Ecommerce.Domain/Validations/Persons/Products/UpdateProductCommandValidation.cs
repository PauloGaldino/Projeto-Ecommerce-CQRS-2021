using Ecommerce.Domain.Commands.Products;

namespace Ecommerce.Domain.Validations.Persons.Products
{
    public class UpdateProductCommandValidation : ProductValidation<UpdateProductCommand>
    {
        public UpdateProductCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateValue();
        }
    }
}
