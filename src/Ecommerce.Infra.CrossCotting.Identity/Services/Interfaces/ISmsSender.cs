using System.Threading.Tasks;

namespace Ecommerce.Infra.CrossCotting.Identity.Services.Interfaces
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
