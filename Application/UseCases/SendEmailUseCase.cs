using Application.DTO;
using Application.Ports.Repositories;
using Application.Ports.Services;
using Domain.Entities;
using Domain.Exceptions;

namespace Application.UseCases
{
    public class SendEmailUseCase
    {
        private readonly IEmailService _emailService;
        private readonly IEmailMessagesRepository _messagesRepository;

        public SendEmailUseCase(IEmailMessagesRepository emailMessagesRepository, IEmailService emailService)
        {
            _emailService = emailService;
            _messagesRepository = emailMessagesRepository;
        }

        public async Task ExecuteAsync(EmailMessageDTO emailMessageDTO)
        {
            try
            {
                await _emailService.SendAsync(emailMessageDTO);

                var entity = new EmailMessage
                {
                    To = emailMessageDTO.To,
                    Subject = emailMessageDTO.Subject,
                    Body = emailMessageDTO.Body
                };

                var result = await _messagesRepository.SaveEmailMessageAsync(entity);
            }
            catch(FooBarException ex)
            {

            }
        }
    }
}
