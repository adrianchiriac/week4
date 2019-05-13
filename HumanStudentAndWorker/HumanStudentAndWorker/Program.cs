using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Catalin", "Stanciu", 7.5);
            Student student2 = new Student("Andrei", "Teodorescu", 7.9);
            Student student3 = new Student("Dan", "Irimia", 9.2);
            Student student4 = new Student("Silviu", "Mereuta", 9.5);
            Student student5 = new Student("Florenta", "Ciobanu", 8.9);
            Student student6 = new Student("Eugenia", "Perianu", 6.5);
            Student student7 = new Student("Ovidiu", "Ionescu", 7.5);
            Student student8 = new Student("Irina", "Breban", 8.0);
            Student student9 = new Student("Bianca", "Rotaru", 7.0);
            Student student10 = new Student("Nicolae", "Vieru", 5.5);
            List<Student> lStudents = new List<Student> { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };
            List<Student> sortedStudents = lStudents.OrderBy(x => x.Grade).ToList();
            foreach (var student in sortedStudents)
            {
                student.Print();
            }
            Console.WriteLine();

            Worker worker1 = new Worker("Zoltan", "Argesanu", 750, 8);
            Worker worker2 = new Worker("Paul", "Odobescu", 650, 8);
            Worker worker3 = new Worker("Mioara", "Bruma", 800, 8);
            Worker worker4 = new Worker("Andrei", "Novac", 700, 6);
            Worker worker5 = new Worker("Dumitru", "Zilieru", 750, 7);
            Worker worker6 = new Worker("Filip", "Rebegea", 700, 7);
            Worker worker7 = new Worker("Corina", "Ursu", 570, 5);
            Worker worker8 = new Worker("Stela", "Iordache", 650, 8);
            Worker worker9 = new Worker("Tudor", "Postelnicu", 600, 7);
            Worker worker10 = new Worker("Vasile", "Gruia", 500, 5);
            List<Worker> lWorkers = new List<Worker> { worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10 };
            List<Worker> sortedWorkers = lWorkers.OrderBy(x => x.MoneyPerHour()).ToList();
            foreach (var worker in sortedWorkers)
            {
                worker.Print();
            }
            Console.WriteLine();

            List<Merged> common = new List<Merged>();

            for (int i = 0; i < lStudents.Count; i++)
            {
                Merged newMerged = new Merged("", "");
                common.Add(newMerged);
                common[i].FirstName = lStudents[i].FirstName; ;
                common[i].LastName = lStudents[i].LastName;
            }
            for (int i = 0; i < lWorkers.Count; i++)
            {
                Merged newMerged = new Merged("", "");
                common.Add(newMerged);
                common[i + 10].FirstName = lWorkers[i].FirstName;
                common[i + 10].LastName = lWorkers[i].LastName;
            }

            List<Merged> sortedMerged = common.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (var merged in sortedMerged)
            {
                merged.Print();
            }

            Console.ReadLine();
        }
    }
}
