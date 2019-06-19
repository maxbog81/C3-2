using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMailSender
{
    public static class TestData
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server{ Name = "Yandex", Address = "smtp.yandex.ru", Port = 25 },
            new Server{ Name = "Mail.ru", Address = "smtp.mail.ru", Port = 25 },
            new Server{ Name = "Gmail", Address = "smtp.gmail.com", Port = 25 }
        };
    }
}
