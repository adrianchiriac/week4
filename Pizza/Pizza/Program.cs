using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase pbR = new PizzaBase();
            Pizza pizza1 = new Pizza(pbR);
            pizza1.Name = "P1";
            pbR.Name = "Regular";
            pbR.Cost = Pizza.regularPizzaBase;
            PizzaTopping pt1R = new PizzaTopping();
            pt1R.Name = "Mozarella";
            pt1R.Cost = 2.7;
            pizza1.AddTopping(pt1R);
            PizzaTopping pt2R = new PizzaTopping();
            pt2R.Name = "Salami".ToUpper();
            pt2R.Cost = 4;
            pizza1.AddTopping(pt2R);
            PizzaTopping pt3R = new PizzaTopping();
            pt3R.Name = "Tomatoes";
            pt3R.Cost = 1.2;
            pizza1.AddTopping(pt3R);
            pizza1.CalculateTotalCost();
            pizza1.Print();
            Console.WriteLine();
            Console.WriteLine();

            PizzaBase pbI = new PizzaBase();
            Pizza pizza2 = new Pizza(pbI);
            pizza2.Name = "P2";
            pbI.Name = "Italian";
            pbI.Cost = Pizza.italianPizzaBase;
            PizzaTopping pt1I = new PizzaTopping();
            pt1I.Name = "Gorgonzola";
            pt1I.Cost = 2.4;
            pizza2.AddTopping(pt1I);
            PizzaTopping pt2I = new PizzaTopping();
            pt2I.Name = "Bacon".ToUpper();
            pt2I.Cost = 4.7;
            pizza2.AddTopping(pt2I);
            PizzaTopping pt3I = new PizzaTopping();
            pt3I.Name = "Corn";
            pt3I.Cost = 1.1;
            pizza2.AddTopping(pt3I);
            pizza2.CalculateTotalCost();
            pizza2.Print();
            Console.WriteLine();
            Console.WriteLine();

            PizzaBase pbT = new PizzaBase();
            Pizza pizza3 = new Pizza(pbT);
            pizza3.Name = "P3";
            pbT.Name = "Thick";
            pbT.Cost = Pizza.thickPizzaBase;
            PizzaTopping pt1T = new PizzaTopping();
            pt1T.Name = "Ricotta";
            pt1T.Cost = 2.7;
            pizza3.AddTopping(pt1T);
            PizzaTopping pt2T = new PizzaTopping();
            pt2T.Name = "Ham".ToUpper();
            pt2T.Cost = 7.1;
            pizza3.AddTopping(pt2T);
            PizzaTopping pt3T = new PizzaTopping();
            pt3T.Name = "Broccoli";
            pt3T.Cost = 2.0;
            pizza3.AddTopping(pt3I);
            pizza3.CalculateTotalCost();
            pizza3.Print();

            Console.ReadLine();
        }
    }
}
