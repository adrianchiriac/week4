using System;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        public double Grade { get; set; }
        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override void Print()
        {
            Console.WriteLine($"Student: {this.FirstName} {this.LastName}  Medie: {this.Grade}");
        }
    }
}
