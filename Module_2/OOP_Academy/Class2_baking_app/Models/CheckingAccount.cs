using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_baking_app
{
    internal class CheckingAccount
    {
        public bool Especial { get; set; }

        public decimal Limit { get; set; }

        public string Client { get; set; }

        public double Interest { get; set; }

        public  CheckingAccount(double number, bool especial, decimal limit, string client, double interest)
        {
            number = number;
            Limit = limit;
            Client = client;
            Especial = especial;
            Interest = interest;

            
        }
        public void Retirar(decimal valor)
        {
            if(())
        }
    }

}
