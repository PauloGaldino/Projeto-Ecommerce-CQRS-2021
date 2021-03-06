using Ecommerce.Domain.Core.Commands;
using Ecommerce.Domain.Core.Events;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Core.Bus.Interfaces
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;

    }
}
