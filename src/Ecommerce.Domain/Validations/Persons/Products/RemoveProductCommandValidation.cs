using Ecommerce.Domain.Commands.Products;

namespace Ecommerce.Domain.Validations.Persons.Products
{
    public class RemoveProductCommandValidation : ProductValidation<RemoveProductCommand>
    {
        public RemoveProductCommandValidation()
        {
            ValidateId();
        }
    }
}
