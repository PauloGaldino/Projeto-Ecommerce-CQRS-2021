using Ecommerce.Domain.Core.Events;
using System;

namespace Ecommerce.Domain.Events.Products
{
    public class ProductRegisteredEvent : Event
    {
        public ProductRegisteredEvent(Guid id, string name, decimal value, bool state)
        {
            Id = id;
            Value = value;
            State = state;
        }

        public Guid Id { get; set; }

        public string Name { get; private set; }

        public decimal Value { get; private set; }

        public bool State { get; private set; }
    }
}
