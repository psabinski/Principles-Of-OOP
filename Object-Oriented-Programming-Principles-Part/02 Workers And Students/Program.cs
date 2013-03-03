using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define abstract class Human with first name and last name. 

//Define new class Student which is derived from Human and has new field – grade. 


//Define class Worker derived from Human with new property 
//WeekSalary and WorkHoursPerDay and method 
//MoneyPerHour() that returns money earned by hour by the worker.

//Define the proper constructors and properties for this hierarchy. 

//Initialize a list of 10 students and sort them by grade in ascending order 
//(use LINQ or OrderBy() extension method). 

//Initialize a list of 10 workers and sort them by money per hour in descending order. 

//Merge the lists and sort them by first name and last name.


namespace _02_Workers_And_Students
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Initialize a list of 10 students and sort them by grade in ascending order 

            //with Array

            //Student[] students = new Student[10]
            //{
            //    new Student(5.5, "Evelin","Petrov"),
            //    new Student(5.4, "Asen","Qnev"),
            //    new Student(5.3, "Vasil","Genchev"),
            //    new Student(5.2, "Stoiko","Petrov"),
            //    new Student(5.5, "Irina","Kostadinova"),
            //    new Student(6, "Vania","Sarandeva"),
            //    new Student(5.8, "Antonia","Velcheva"),
            //    new Student(5.1,"Buriana","Iordanova"),
            //    new Student(4.1, "Elica","Iordanoav"),
            //    new Student(5.5, "Ivan","Ivanov"),

            //};

            //Array.Sort(students, (s1, s2) => s2.Grade.CompareTo(s1.Grade));

            List<Student> students = new List<Student>();

            students.Add(new Student(5.5, "Evelin", "Petrov"));
            students.Add(new Student(5.4, "Asen","Qnev"));
            students.Add(new Student(5.3, "Vasil","Genchev"));
            students.Add(new Student(5.2, "Stoiko","Petrov"));
            students.Add(new Student(5.5, "Irina","Kostadinova"));
            students.Add(new Student(6, "Vania","Sarandeva"));
            students.Add(new Student(5.8, "Antonia","Velcheva"));
            students.Add(new Student(5.1,"Buriana","Iordanova"));
            students.Add(new Student(4.1, "Elica","Iordanoav"));
            students.Add(new Student(5.5, "Ivan","Ivanov"));

            var sorted = students.OrderByDescending(item => item.Grade); // to be printed ascending


            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            
                 workers.Add(new Worker(550,11, "Ivan", "Goshev"));
                 workers.Add(new Worker(900,8, "Peso", "Peshev"));
                 workers.Add(new Worker(800,3, "Asen", "Blatechki"));
                 workers.Add(new Worker(700,5, "Pencho", "Popadiinski"));
                 workers.Add(new Worker(500,1, "Todor", "Jivkov"));
                 workers.Add(new Worker(400,2, "Vasko", "Krupkata"));
                 workers.Add(new Worker(450,8, "Anton", "Hikemian"));
                 workers.Add(new Worker(500,9, "Bai", "Baluk"));
                 workers.Add(new Worker(600,10, "Gsohe", "Tumbevski"));
                 workers.Add(new Worker(500,16, "Konan", "The Barberian"));


                 //Initialize a list of 10 workers and sort them by money per hour in descending order. 

                 var sortedByMoneyPerHour = 
             from worker in workers
             orderby worker.MoneyPerHour() ascending
             select worker;


                 foreach (var worker in sortedByMoneyPerHour)
                 {
                     Console.WriteLine(worker);
                 }

                 //Merge the lists and sort them by first name and last name.
                 var studentsNames =
                 students.Select(s => new { s.FirsiName, s.LastName });

                 var workersNames =
                     workers.Select (w => new { w.FirsiName, w.LastName });

                 var allNames = studentsNames.Concat(workersNames);

                 Console.WriteLine();
                 foreach (var person in allNames.OrderBy(item => item.FirsiName).ThenBy(item => item.LastName)) 
                 {
                     Console.WriteLine(person);
                 }

        }
    }
}
