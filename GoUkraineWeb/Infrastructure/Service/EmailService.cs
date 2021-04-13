using Domain;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Infrastructure.Service
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendEmail(object model, string subject, List<Attachment> attachments = null)
        {
            var from = new MailAddress(_configuration.GetSection(Constants.Config.EmailSettings.SectionName)[Constants.Config.EmailSettings.FromEmailKey], subject);
            var to = new MailAddress(_configuration.GetSection(Constants.Config.EmailSettings.SectionName)[Constants.Config.EmailSettings.ToEmailKey]);
            var message = new MailMessage(from, to)
            {
                Subject = subject,
                Body = ToBodyMessage(model),
                IsBodyHtml = false,
            };
            if (attachments != null)
                attachments.ForEach(x => message.Attachments.Add(x));

            var smtpClient = new SmtpClient(_configuration.GetSection(Constants.Config.EmailSettings.SectionName)[Constants.Config.EmailSettings.SmtpHostKey], int.Parse(_configuration.GetSection(Constants.Config.EmailSettings.SectionName)[Constants.Config.EmailSettings.SmtpPortKey]))
            {
                Credentials = new NetworkCredential(_configuration.GetSection(Constants.Config.EmailSettings.SectionName)[Constants.Config.EmailSettings.FromEmailKey], _configuration.GetSection(Constants.Config.EmailSettings.SectionName)[Constants.Config.EmailSettings.SmtpPasswordKey])
            };
            smtpClient.Send(message);
        }
        private string ToBodyMessage(object obj)
        {
            var message = "";
            var type = obj.GetType();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                var attrName = (prop.GetCustomAttributes(typeof(DisplayNameAttribute), false).FirstOrDefault() as DisplayNameAttribute)?.DisplayName;
                if (string.IsNullOrWhiteSpace(attrName)) continue;
                message += $"{attrName}: {prop.GetValue(obj)}\r\n";
            }
            return message;
        }
    }
}
