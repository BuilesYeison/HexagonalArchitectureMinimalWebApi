using Application.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ports.Repositories
{
    public interface IEmailMessagesRepository
    {
        Task<EmailMessage> SaveEmailMessageAsync(EmailMessage message);
    }
}
