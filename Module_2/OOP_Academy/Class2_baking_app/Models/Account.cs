using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class2_banking_app.Exceptions;
namespace Class2_banking_app.Models
{
    internal class Account
    {
        public decimal balance { get; set; }
        public ushort acc_number { get; set; }
        public void Deposit(Decimal valor)
        {
            //verifying if the inserted value is valid
            if(valor <= 0)
            {
                throw new ArgumentException("The value can't be negative or 0");
            }
            else
            {
                balance += valor;
            }
        }
        public void Withdrawal(decimal value)
        {
            if (value < balance)
            {
                throw new InsufficientBalanceException("Insufficient balance, please check the inputed value and your balance");
            }
            else
            {
                balance -= value;
                Console.WriteLine("You've just drew: ", value);
                Console.WriteLine("Now your balance is: ", balance);
            }
        }

    }
}
