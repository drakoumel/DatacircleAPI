using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatacircleAPI.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Email email);
    }
}
