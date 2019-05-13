using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        public List<int> St { get; set; } = new List<int>();

        public void Push(int element)
        {
            this.St.Add(element);
        }

        public void Pop()
        {
            this.St.Remove(St[St.Count-1]);
        }

        public int Count()
        {
            return this.St.Count();
        }

        public void Print(string mesaj)
        {
            Console.Write(mesaj);
            foreach (var element in St)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
