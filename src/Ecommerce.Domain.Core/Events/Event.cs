using MediatR;
using System;

namespace Ecommerce.Domain.Core.Events
{
    public abstract class Event : Message, INotification
    {
        public DateTime TimeStamp { get; private set; }

        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
