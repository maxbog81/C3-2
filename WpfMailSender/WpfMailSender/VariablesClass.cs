using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodePasswordDLL;

namespace WpfMailSender
{

    public static class VariablesClass
    {
        public static Dictionary<string, string> Senders
        {
            get { return dicSenders; }
        }
        private static Dictionary<string, string> dicSenders = new Dictionary<string, string>()
        {
            { "maks.20sm.79@mail.ru", CodePassword.getPassword("89:1wgsd") },
            { "sok74@yandex.ru", CodePassword.getPassword("{3t1l2m6") }
        };

        public static Dictionary<string, int> SmtpServers
        {
            get { return dicSmtpServers; }
        }
        private static Dictionary<string, int> dicSmtpServers = new Dictionary<string, int>()
        {
            { "smtp.mail.ru", 2525 },
            { "smtp.yandex.ru", 25 }
        };
    }

}
