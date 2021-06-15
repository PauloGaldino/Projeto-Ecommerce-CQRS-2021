using Ecommerce.Domain.Core.Events;
using FluentValidation.Results;
using System;

namespace Ecommerce.Domain.Core.Commands
{
    public abstract class Command : Event
    {
        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public abstract bool IsValid();
    }
}
