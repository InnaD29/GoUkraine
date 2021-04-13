using Domain.Dtos;
using Infrastructure.Service;
using Application.Models;

namespace Application.Managers
{
    public class EmailManager
    {
        private const string CONTACT_US_SUBJECT = "DIS TOUR: Contact us";

        private readonly EmailService _emailService;

        public EmailManager(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void SendContactUsEmail(ContactUsModel model)
        {
            var dto = new SendEmailDto
            {
                SenderName = model.SenderName,
                PhoneNumber = model.PhoneNumber
            };
            _emailService.SendEmail(dto, CONTACT_US_SUBJECT);
        }
    }
}