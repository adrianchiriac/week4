using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
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

            Stack st = new Stack();
            for (int i = 1; i <= 4; i++)
            {
                st.Push(i * 10);
            }
            do
            {
                choice = SelectOperation();
                Console.Clear();
                Menu();
                switch (choice)
                {
                    case '1':
                        AddElementsStack(st, MaxElements);
                        break;
                    case '2':
                        RemoveElementsStack(st);
                        break;
                    case '3':
                        DisplayElementsStack(st);
                        break;
                    default:
                        exit_loop = 1;
                        break;
                }
            } while (exit_loop != 1);
            Console.WriteLine("   [   Now you'll exit the program!   ]");
            Console.ReadLine();

        }

        private static void DisplayElementsStack(Stack st)
        {
            Console.Write($"   [   Number of elements: {st.Count()}   ");
            st.Print("   Elements: ");
            Console.WriteLine("  ]");
            Console.WriteLine();
        }

        private static void Menu()
        {
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("   1. Push");
            Console.WriteLine();
            Console.WriteLine("   2. Pop");
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

        private static Stack AddElementsStack(Stack st, int maxElements)
        {
            if (st.Count() >= maxElements)
            {
                Console.Write($"   [   Stack Reached Max! ({maxElements} elements)  ]");
            }
            else
            {
                Console.Write("   Add element: ");
                int el = Convert.ToInt32(Console.ReadLine());
                st.Push(el);
                Console.Clear();
                Menu();
                Console.Write($"   [    {el} has been added   ]");
            }
            Console.WriteLine();
            Console.WriteLine();

            return st;
        }

        private static Stack RemoveElementsStack(Stack st)
        {
            Console.Clear();
            Menu();
            if (st.Count() <= 0)
            {
                Console.Write("   [   Stack is Empty!   ]");
            }
            else
            {
                Console.Write($"   [   {st.St[st.St.Count-1]} has been removed   ]");
                st.Pop();
            }
            Console.WriteLine();
            Console.WriteLine();

            return st;
        }
    }
}
