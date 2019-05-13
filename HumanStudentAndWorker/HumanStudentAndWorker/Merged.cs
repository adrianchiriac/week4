using System;

namespace HumanStudentAndWorker
{
    class Merged : Human
    {
        public Merged(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Oameni: {this.FirstName} {this.LastName}");
        }
    }
}
