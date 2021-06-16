using Ecommerce.Domain.Core.Commands;
using System;

namespace Ecommerce.Domain.Commands.Products
{
    public abstract class ProductCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public decimal Value { get; protected set; }
        public bool State { get; protected set; }
    }
}
