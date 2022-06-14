using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class2_banking_app.Exceptions;
namespace Class2_banking_app.Models
{
    class SavingAccount : Account, IInvestmentAccount
    {
        public decimal Yield { get; set; }
    
        public SavingAccount(double number)
        {
            number = acc_number;
        }

        public decimal ReturnOnInvestment(decimal rate)
        {
            return balance * rate;
        }

    }
}
