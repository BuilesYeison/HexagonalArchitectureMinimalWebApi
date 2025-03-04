using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ports.Services
{
    public interface IEmailService
    {
        Task SendAsync(EmailMessageDTO emailMessageDTO);
    }
}
