using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_02
{
    internal class EmailLog : ILog
    {
        private const string email = "rasika@idea-capz.io";

        public void Write(string message)
        {
            Console.WriteLine($"email from {email} send message {message}");
        }
    }
}
