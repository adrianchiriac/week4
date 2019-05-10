using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaBase
    {
        public string Name;
        public double Cost;
        public void Print()
        {
            Console.WriteLine($"Base: {this.Name} (${this.Cost})");
        }
    }
}
