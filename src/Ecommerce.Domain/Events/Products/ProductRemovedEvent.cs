using Ecommerce.Domain.Core.Events;
using System;

namespace Ecommerce.Domain.Events.Products
{
    public class ProductRemovedEvent : Event
    {
        public ProductRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
