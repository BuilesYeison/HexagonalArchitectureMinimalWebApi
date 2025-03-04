using Application.DTO;
using Application.Ports.Services;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Adapters.Services
{
    public class SendGridService : IEmailService
    {
        private readonly ILogger<SendGridService> _logger;

        public SendGridService(ILogger<SendGridService> logger)
        {
            _logger = logger;
        }

        public async Task SendAsync(EmailMessageDTO emailMessageDTO)
        {
            _logger.LogInformation($"Sending message to {emailMessageDTO.To} from sendgrid");
        }
    }
}
