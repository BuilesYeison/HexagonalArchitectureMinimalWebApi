using Application.DTO;
using Application.Ports.Repositories;
using Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Adapters.Repositories
{
    public class EmailMessagesRepository : IEmailMessagesRepository
    {
        private readonly ILogger<EmailMessagesRepository> _logger;

        public EmailMessagesRepository(ILogger<EmailMessagesRepository> logger)
        {
            _logger = logger;
        }

        public async Task<EmailMessage> SaveEmailMessageAsync(EmailMessage message)
        {
            _logger.LogInformation($"Saving message in database: {message}");

            return message;
        }
    }
}
