using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Rate
    {
        public int Ammount;
        public string Currency;

        public void Print()
        {
            Console.WriteLine($"Ammount = {this.Ammount}, Currency = {this.Currency}");
        }
    }
}
