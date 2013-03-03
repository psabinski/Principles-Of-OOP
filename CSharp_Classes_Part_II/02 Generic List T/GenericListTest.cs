using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generic_List_T
{
    class GenericListTest
    {
        static void Main(string[] args)
        {

            GenericList<int> list = new GenericList<int>(10);

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list.Count);

        }
    }
}
