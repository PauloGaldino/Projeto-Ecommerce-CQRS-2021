using System.Threading.Tasks;

namespace Ecommerce.Domain.Core.Events.Interfaces
{
    public interface IHandler<in T> where T : Message
    {
        void Handler(Task message);
    }
}
