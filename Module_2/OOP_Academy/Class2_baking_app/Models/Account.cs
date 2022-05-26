﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_banking_app.Models
{
    internal class Account
    {
        public decimal Saldo { get; set; }
        public ushort Acc_numver { get; set; }
        public void Deposit(Decimal valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("The value can't be negative or 0")
            }
        }

    }
}