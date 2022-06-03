using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5.Models
{
    abstract class Estabelecimento
    {

        public String Name { get; set; }
        public String ID { get; set; }

        public abstract decimal CalculateTax(decimal tax);
    }
}
