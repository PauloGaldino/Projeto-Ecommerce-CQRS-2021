using Ecommerce.Domain.Core.Commands;
using System;

namespace Ecommerce.Domain.Commands.Persons.Customers
{
    public abstract class CustomerCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }
    }
}
