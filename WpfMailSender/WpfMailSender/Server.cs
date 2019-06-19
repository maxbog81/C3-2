﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMailSender
{
    public class Server
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Port { get; set; } = 2525;
        public bool UseSSL { get; set; } = true;

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
