using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Roles.Services
{
   

    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // No-op (or log to console)
            return Task.CompletedTask;
        }
    }

}
