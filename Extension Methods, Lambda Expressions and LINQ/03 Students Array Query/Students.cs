using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//03
//Write a method that from a given array of students 
//finds all students whose first name is before its last
//name alphabetically. Use LINQ query operators.

//04 Write a LINQ query that finds the first name and 
//last name of all students with age between 18 and 24.

//05 Using the extension methods OrderBy() and ThenBy() with 
//lambda expressions sort the students by first name and last 
//name in descending order. Rewrite the same with LINQ.


namespace _03_Students_Array_Query
{
    class Students
    {
        private string name;
        private string family;
        private int age;


        Students(string name, string family, int age)
        {
            this.name = name;
            this.family = family;
            this.age = age;
        }




        static void Main(string[] args)
        {
            Students[] studentData = new Students[6]
            {
                new Students("Peter", "Ivanov", 20),
                new Students("Ivan", "Petrov",19),
                new Students("Ivan", "Georgiev",22),
                new Students("Georgi", "Iordanov", 26),
                new Students("Veselin", "Asenov", 30),
                new Students("Anton", "Stefanov", 30)
            };

            //03


            var selectionName =
     from s in studentData
     where s.name.CompareTo(s.family) == 1
     select s;

            Console.WriteLine("All students whose first name is before its last name alphabetically");
            Console.WriteLine();

            foreach (var item in selectionName)
            {
                Console.WriteLine(item.family + " " + item.name);
            }

            Console.WriteLine();
            //04

            var selectionAge =
    from s in studentData
    where (s.age >= 18 && s.age <= 24)
    select s;

            Console.WriteLine("Age between 18 and 24");
            Console.WriteLine();

            foreach (var item in selectionAge)
            {
                Console.WriteLine(item.name + " " + item.family + " Age: " + item.age + "years old");
            }

            Console.WriteLine();

            //05 Using the extension methods OrderBy() and ThenBy() with 
            //lambda expressions sort the students by first name and last 
            //name in descending order. Rewrite the same with LINQ.


            Console.WriteLine("Sorted  by first name and last in descending order \n");
            //name in descending order);

            var sorted = studentData.OrderByDescending(x => x.name).ThenBy(x => x.family);

            foreach (Students item in sorted)
            {
                Console.WriteLine(item.name + " " + item.family + " Age: " + item.age + "years old");
            }

            // Rewrite the same with LINQ.
            var order =
   from s in studentData
   orderby s.name descending, s.family descending
   select s;

            Console.WriteLine();
            Console.WriteLine("Same operation with LINQ \n");
            foreach (var item in order)
            {
                Console.WriteLine(item.name + " " + item.family + " Age: " + item.age + "years old");
            }



        }
    }
}
