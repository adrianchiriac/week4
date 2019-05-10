using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        public string Name;
        public string City;
        public List<Room> room = new List<Room>();

        public int GetPriceForNumberOfRooms(int numberOfRooms)
        {
            return room[numberOfRooms - 1].rate.Ammount;
        }

        public void Print()
        {
            Console.WriteLine($"Hotel: {this.Name}");
            Console.WriteLine($"Oras:  {this.City}");
            foreach (var item in room)
            {
                Console.WriteLine($"Nume camera: {item.Name}  Pret: {item.rate.Ammount} {item.rate.Currency}  " +
                    $"Adulti: {item.Adults}  Copii: {item.Children}");
            }
        }
    }
}
