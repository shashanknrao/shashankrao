using System;
using System.Net;
using System.Net.Mail;

namespace NinjectNet
{
    class MailService
    {
        private ILogger logger;
        private SmtpClient client;
        private readonly string sender;

        public MailService(MailServerConfig config, ILogger logger)
        {
            this.logger = logger;
            IniltilizeClient(config);
            sender = config.SenderMail;
        }

        public void SendEmail(string address, string subject, string
            body)
        {
            var mail = new MailMessage();
            mail.To.Add(address);
            mail.Subject = subject;
            mail.Body = body;
            var client = new SmtpClient();
            // Setup client with smtp server address and port here
            // Setup client with smtp server address and port here
            Console.WriteLine("Sending message...");
            client.Send(mail);
            Console.WriteLine("Message sent successfully.");
        }

        private void IniltilizeClient(MailServerConfig config)
        {
            client = new SmtpClient();
            client.Host = config.SmtpServer;
            client.Port = config.SmtpPort;
            client.EnableSsl = true;

            var credentials = new NetworkCredential();
            credentials.UserName = config.SenderEmail;
            credentials.Password = config.SenderPassword;
            client.Credentials = credentials
        }
    }
}
