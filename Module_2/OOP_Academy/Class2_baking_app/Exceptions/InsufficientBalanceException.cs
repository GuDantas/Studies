using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_banking_app.Exceptions
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string msg) : base(msg)
        {

        }
    }
}
