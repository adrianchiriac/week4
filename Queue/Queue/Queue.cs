using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Queue
{
    class Queue
    {
        public List<int> Q { get; set; } = new List<int>();

        public void Enqueue(int element)
        {
            this.Q.Add(element);
        }

        public void Dequeue()
        {
            this.Q.Remove(Q[0]);
        }

        public int Count()
        {
            return this.Q.Count();
        }
        public void Print(string mesaj)
        {
            Console.Write(mesaj);
            foreach (var element in Q)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
