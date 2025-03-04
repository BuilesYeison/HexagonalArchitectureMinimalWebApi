using Application.DTO;
using Application.Ports.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Adapters.Services
{
    public class TwilioService : IEmailService
    {
        private readonly ILogger<TwilioService> _logger;

        public TwilioService(ILogger<TwilioService> logger)
        {
            _logger = logger;
        }

        public async Task SendAsync(EmailMessageDTO emailMessageDTO)
        {
            _logger.LogInformation($"Sending message to {emailMessageDTO.To} from twilio");
        }
    }
}
