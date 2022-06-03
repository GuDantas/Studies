using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Services
{
     interface IMassage
    {
        void SendMessage(string message, string subject);

        void SendMessage(string message);
        
    }
}
