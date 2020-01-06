using System;
using System.Configuration;

namespace NinjectNet
{
    internal class MailServerConfig
    {
        public string SmtpServer => ConfigurationManager.AppSettings["SmtpServer"];

        public string SenderMail => ConfigurationManager.AppSettings["SenderMail"];

        public int SmtpPort
        {
            get
            {
                var port = ConfigurationManager.AppSettings["SmtpPort"];
                return Convert.ToInt16(port);
            }
        }

        public string SenderPassword => ConfigurationManager.AppSettings["SenderPassword"];

        public string SenderEmail => ConfigurationManager.AppSettings["SenderMail"];
    }