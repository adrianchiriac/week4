using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaTopping
    {
        public string Name;
        public double Cost;
        public void Print()
        {
            Console.WriteLine($"        {this.Name} (${this.Cost})");
        }
    }
}
