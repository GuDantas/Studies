using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class6.Services;
using Class6.Exceptions;

namespace Class6.Services
{

     class IMessageEmail : IMassage{
        void IMassage.SendMessage(string message, string subject) { }
        void IMassage.SendMessage(string message){
        //putting a limit to the message
            if(message.Length > 300)
            {
                throw new InvalidMessageException();
            }
            Console.WriteLine("Sending a SMS with the message: {0}",message );
        }
    }
}
