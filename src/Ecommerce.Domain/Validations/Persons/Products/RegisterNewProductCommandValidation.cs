using Ecommerce.Domain.Commands.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
