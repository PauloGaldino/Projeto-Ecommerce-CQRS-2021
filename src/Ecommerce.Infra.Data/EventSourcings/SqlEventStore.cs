using Ecommerce.Domain.Core.Events;
using Ecommerce.Domain.Core.Events.Interfaces;
using Ecommerce.Domain.Interfaces.Persons.Users;
using Ecommerce.Infra.Data.Repositories.EventSourcing.Iterfaces;
using Newtonsoft.Json;

namespace Ecommerce.Infra.Data.EventSourcings
{
    public class SqlEventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IUser _user;

        public SqlEventStore(IEventStoreRepository eventStoreRepository, IUser user)
        {
            _eventStoreRepository = eventStoreRepository;
            _user = user;
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new StoredEvent(theEvent, serializedData, _user.Name);

            _eventStoreRepository.Store(storedEvent);
        }
    }
}
