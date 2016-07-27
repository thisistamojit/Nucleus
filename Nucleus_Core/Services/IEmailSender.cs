using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nucleus_Core.Services
{
 /// <summary>
/// Service for sending  Email
/// </summary>
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
