using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Room
    {
        public string Name;
        public Rate rate = new Rate();
        public int Adults;
        public int Children;
        
        public int GetPriceForDays(int numberOfDays)
        {
            //this.PretNzile = this.rate.Ammount * numberOfDays;
            return rate.Ammount * numberOfDays;
        }

        public void Print()
        {
            Console.WriteLine($"Name = {this.Name}, rate = {this.rate.Ammount} {this.rate.Currency}, Adults = {this.Adults}, Children = {this.Children}");
        }
    }
}
