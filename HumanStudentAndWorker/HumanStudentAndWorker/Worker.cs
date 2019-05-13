using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }
        double Money_Per_Hour { get; set; }

        public double MoneyPerHour()
        {
            Money_Per_Hour = (WeekSalary / (WorkHoursPerDay * 5));
            return Money_Per_Hour;
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override void Print()
        {
            Console.WriteLine($"Muncitor: {this.FirstName} {this.LastName}  Salariu/sapt.: {this.WeekSalary}  Ore/zi: {this.WorkHoursPerDay}  Salariu/ora: {this.Money_Per_Hour.ToString("0.00")}");
        }
    }
}
