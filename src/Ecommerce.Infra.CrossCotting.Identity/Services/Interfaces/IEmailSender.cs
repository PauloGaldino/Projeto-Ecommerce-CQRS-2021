using System.Threading.Tasks;

namespace Ecommerce.Infra.CrossCotting.Identity.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
