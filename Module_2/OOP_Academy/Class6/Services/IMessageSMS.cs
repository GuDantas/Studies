using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Services
{
    internal class IMessageSMS : IMassage
    {
        void IMassage.SendMessage(string message) {
               
        }
        void IMassage.SendMessage(string message, string subject) { }
    }
}
