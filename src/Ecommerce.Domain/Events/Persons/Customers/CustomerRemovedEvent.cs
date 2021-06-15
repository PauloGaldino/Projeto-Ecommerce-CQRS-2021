using Ecommerce.Domain.Core.Events;
using System;

namespace Ecommerce.Domain.Events.Persons.Customers
{
    public class CustomerRemovedEvent : Event
    {
        public CustomerRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
