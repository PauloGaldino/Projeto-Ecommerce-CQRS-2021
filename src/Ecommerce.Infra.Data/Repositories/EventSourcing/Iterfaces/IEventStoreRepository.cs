using Ecommerce.Domain.Core.Events;
using System;
using System.Collections.Generic;

namespace Ecommerce.Infra.Data.Repositories.EventSourcing.Iterfaces
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);

        IList<StoredEvent> All(Guid aggregateId);
    }
}
