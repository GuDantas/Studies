using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class2_banking_app.Models;

 class CheckingAccount : Account
{
    public bool Especial { get; set; }

    public decimal Limit { get; set; }

    public string Client { get; set; }

    public double Interest { get; set; }

    public SavingAccount SavingAccount { get; set; }

    public  CheckingAccount(double number, bool especial, decimal limit, string client, double interest, SavingAccount savingAccount)
    {
        number = acc_number;
        Limit = limit;
        Client = client;
        Especial = especial;
        Interest = interest;
        SavingAccount = savingAccount;
        
    }
   
}

