using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        public string Name;
        public PizzaBase pizzaBase = new PizzaBase();
        public List<PizzaTopping> pizzaTopping = new List<PizzaTopping>();
        public static double regularPizzaBase = 3.0;
        public static double italianPizzaBase = 1.5 * regularPizzaBase;
        public static double thickPizzaBase = 4.0;
        double SumaTotala = 0.0;


        public void AddTopping(PizzaTopping pt)
        {
            pizzaTopping.Add(pt);
        }

        public void CalculateTotalCost()
        {
            SumaTotala += pizzaBase.Cost;
            foreach (var item in pizzaTopping)
            {
                SumaTotala += item.Cost;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Pizza {this.Name}");
            pizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var item in pizzaTopping)
            {
                item.Print();
            }
            Console.WriteLine($"Total Cost: ${SumaTotala}");
        }

        public Pizza(PizzaBase pizzaB)
        {
            this.pizzaBase = pizzaB;
        }
    }
}
