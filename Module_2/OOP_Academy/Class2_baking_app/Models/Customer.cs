using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_baking_app
{
    internal class Customer
    {
        // properties
        public string name { get; set; }
        public string CPF_ID { get; set; }
        public double telephone { get; set; }
        
        // In Brazil we call this from Construtor, in inglish would sound like
        // builder, manufacturer, something like these
        public Customer(string _name, string _CPF_ID, double _telephone)
        {
            name = _name;
            CPF_ID = _CPF_ID;
            telephone = _telephone;

        }
    }
}
