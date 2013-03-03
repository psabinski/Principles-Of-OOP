using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define class Worker derived from Human with new property 
//WeekSalary and WorkHoursPerDay and method 
//MoneyPerHour() that returns money earned by hour by the worker.

namespace _02_Workers_And_Students
{
    class Worker : Human
    {
        private  double weekSalary;
        private int workHoursPerDay;


        public int WeekHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }
           

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set{ this.weekSalary= value; }
        }

        public Worker(double weekSalary, int workHoursPerDay, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public  double MoneyPerHour()
        {
           return this.WeekSalary/(this.workHoursPerDay*5);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} is earning ${2:0.00} per hour",
                this.FirsiName, this.LastName, this.MoneyPerHour());
        }
    }
}
