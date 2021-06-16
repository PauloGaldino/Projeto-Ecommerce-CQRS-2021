using Ecommerce.Domain.Commands.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Validations.Persons.Products
{
    public class ProductValidation<T> : AbstractValidator<T> where T : ProductCommand
    {

        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        
        protected void ValidateValue()
        {
            RuleFor(c => c.Value)
                .Null().WithMessage("This value can't be null")
                .Empty().WithMessage("This value is required, it can't be empty.");
        }

      

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}