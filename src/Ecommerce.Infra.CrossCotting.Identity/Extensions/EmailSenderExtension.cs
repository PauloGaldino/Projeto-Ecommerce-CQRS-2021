using Ecommerce.Infra.CrossCotting.Identity.Services.Interfaces;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Ecommerce.Infra.CrossCotting.Identity.Extensions
{
    public static class EmailSenderExtension
    {
        public static Task SendEmailConfirmation(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Confirm your email",
            $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");

        }
    }
}
