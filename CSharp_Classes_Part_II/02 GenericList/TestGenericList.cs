using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericList
{
    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(2);
            //Add
            list.Add(100);
            list.Add(200);
            list.Add(300);

            Print<int>(list);

            // Removing element 0
            list.Remove(0);

            Console.WriteLine();
            Console.WriteLine("element [0] was removed");


            Console.WriteLine();
            Print<int>(list);

            Console.WriteLine();
            Console.WriteLine("Adding element with value 500");
            
            list.Add(500);
            Console.WriteLine();
           

            Print<int>(list);
            // Insert
            Console.WriteLine();
            Console.WriteLine("Adding element with value 1000 on polsition 1");
            list.Insert(1, 1000);

            Print<int>(list);
            // Clear
            Console.WriteLine();
            Console.WriteLine("Clearing the list");
            list.Clear();

            Console.WriteLine("Adding element with value 5000");
            Console.WriteLine("Adding element with value 10");
            Console.WriteLine("Adding element with value 6000");
            list.Add(5000);
            list.Add(10);
            list.Add(6000);

            Console.WriteLine("Printing the list");
            Console.WriteLine();

            Print<int>(list);
            Console.WriteLine();
            //Finding element by its value
            Console.WriteLine("Looking for element with value 10.. >Find< will return the index");
            Console.WriteLine(GenericList<int>.Find<int>(list,10));

            Console.WriteLine();

            Console.WriteLine("Looking for element with value 100.. it doesn't exist.. >Find< will return -1");
            Console.WriteLine(GenericList<int>.Find<int>(list, 100));

            Console.WriteLine();

            // To String

            Console.WriteLine("To String: " + list);
            Console.WriteLine();
           
            // Min & Max
            int min = GenericList<int>.Min<int>(list);
            Console.WriteLine("The MIN element is :");
            Console.WriteLine(min);

            Console.WriteLine();

            Console.WriteLine("The MAX element is :");
            Console.WriteLine(GenericList<int>.Max<int>(list));
            
        }

        static void Print<T>(GenericList<T> list)
        {
             for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
