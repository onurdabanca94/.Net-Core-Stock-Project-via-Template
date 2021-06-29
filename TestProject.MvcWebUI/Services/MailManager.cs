using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.MvcWebUI.Models.Services
{
    public class MailManager : IMailService
    {
        private IHostingEnvironment _hostingEnvironment;
        private IEmailConfiguration _emailConfiguration;

        public MailManager(IHostingEnvironment hostingEnvironment, IEmailConfiguration emailConfiguration)
        {
            _hostingEnvironment = hostingEnvironment;
            _emailConfiguration = emailConfiguration;
        }
        public void Send(EmailMessage emailMessage)
        {
            var message = new MimeMessage();
            message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            message.Subject = emailMessage.Subject;

            var templatePath = _hostingEnvironment.WebRootPath +
                Path.DirectorySeparatorChar.ToString() + "MailTemplate" +
                Path.DirectorySeparatorChar.ToString() + "MailTemplate.html";
            var builder = new BodyBuilder();
            using (StreamReader sourceReader = File.OpenText(templatePath))
            {
                builder.HtmlBody = sourceReader.ReadToEnd();
            }
            string messageBody = string.Format(builder.HtmlBody, emailMessage.Subject, emailMessage.Content);

            message.Body = new TextPart(TextFormat.Html)
            {
                Text = messageBody
            };

            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect("smtp.gmail.com",465,MailKit.Security.SecureSocketOptions.SslOnConnect);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }
        }
    }
}
