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
            { "maks.20sm.79@mail.ru", CodePassword.getPassword("Ychg`Ocwg.234") },
            { "sok74@yandex.ru", CodePassword.getPassword("{3t1l2m6") }
        };
    }

}
