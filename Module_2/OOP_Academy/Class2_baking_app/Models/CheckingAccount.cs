using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class2_banking_app.Models;

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
    public void Withdraw(decimal value)
    {
        if(<=value)
    }
}

