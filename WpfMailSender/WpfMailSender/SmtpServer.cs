using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMailSender
{
    public static class SmtpServer
    {
        public static int Port { get; set; } = 25;
        public static string Host { get; set; } = "smtp.mail.ru";
        public static string Sender { get; set; } = "max8134bog@list.ru";
        public static string Subject { get; set; } = "Привет из C#";
        public static string Body { get; set; } = "Hello, world!";
        public static List<string> ListStrMails { get; set; } = new List<string>() { "maxbog@inbox.ru", "max8134bog@list.ru" };

    }
}
