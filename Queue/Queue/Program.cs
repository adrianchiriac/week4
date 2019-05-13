using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = ' ';
            int MaxElements = 10;
            int exit_loop = 0;
            Menu();
            Console.WriteLine();
            Console.WriteLine();

            Queue q = new Queue();
            for (int i = 1; i <= 10; i++)
            {
                q.Enqueue(++i);
            }

            do
            {
                choice = SelectOperation();
                Console.Clear();
                Menu();
                switch (choice)
                {
                    case '1':
                        AddElementsQueue(q, MaxElements);
                        break;
                    case '2':
                        RemoveElementsQueue(q);
                        break;
                    case '3':
                        DisplayElementsQueue(q);
                        break;
                    default:
                        exit_loop = 1;
                        break;
                }
            } while (exit_loop != 1);

            Console.WriteLine("   [   Now you'll exit the program!   ]");
            Console.ReadLine();
        }

        private static void DisplayElementsQueue(Queue q)
        {
            Console.Write($"   [   Number of elements: {q.Count()}   ");
            q.Print("   Elements: ");
            Console.WriteLine("  ]");
            Console.WriteLine();
        }

        private static void Menu()
        {
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("   1. Enqueue");
            Console.WriteLine();
            Console.WriteLine("   2. Dequeue");
            Console.WriteLine();
            Console.WriteLine("   3. Display");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }

        private static char SelectOperation()
        {
            Console.Write("   Enter Your Choice: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return ch;
        }

        private static Queue AddElementsQueue(Queue q, int maxElements)
        {
            if (q.Count() >= maxElements)
            {
                Console.Write($"   [   Queue Reached Max! ({maxElements} elements)  ]");
            }
            else
            {
                Console.Write("   Add element: ");
                int el = Convert.ToInt32(Console.ReadLine());
                q.Enqueue(el);
                Console.Clear();
                Menu();
                Console.Write($"   [    {el} has been added   ]");
            }
            Console.WriteLine();
            Console.WriteLine();

            return q;
        }

        private static Queue RemoveElementsQueue(Queue q)
        {
            Console.Clear();
            Menu();
            if (q.Count() <= 0) 
            {
                Console.Write("   [   Queue is Empty!   ]");
            }
            else
            {
                Console.Write($"   [   {q.Q[0]} has been removed   ]");
                q.Dequeue();
            }
            Console.WriteLine();
            Console.WriteLine();

            return q;
        }
    }
}
