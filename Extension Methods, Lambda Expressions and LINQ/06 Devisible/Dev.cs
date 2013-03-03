using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array of integers 
//all numbers that are divisible by 7 and 3. Use the built-in 
//extension methods and lambda expressions. Rewrite the same with LINQ.


namespace _06_Devisible
{
    class Dev
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 9, 22, 21, 4, 63, 70, 10, 33 };

            var selection = list.FindAll((i) => (i % 3) == 0 && (i % 7) == 0);

            Console.WriteLine("Lambda operation \n");
            foreach (var item in selection)
            {
                Console.WriteLine(item);
            }

            // same operation with LINQ

            Console.WriteLine("\nSame operation with LINQ \n");
            var selected =
   from s in list
   where (s % 3==0 && s % 7 == 0)
   select s;

            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }
    }
}
