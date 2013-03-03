using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement a set of extension methods for IEnumerable<T> 
//that implement the following group functions: sum, product, min, max, average

namespace _02_Extention_Methods
{
    
    
    public static class Extentions
    {
        public static T Min<T>(this IEnumerable<T> param)
            where T : IComparable<T>
        {
            return param.OrderBy(x => x).ToArray()[0];
        }

        public static T Max<T>(this IEnumerable<T> param)
            where T : IComparable<T>
        {
            return param.OrderByDescending(x => x).ToArray()[0];
        }

        public static T Sum<T>(this IEnumerable<T> param)
        {
            
            dynamic sum = 0;
            foreach (var item in param)
            {
                
                sum += item;
            }

            return sum;

        }
        
        public static T Product<T>(this IEnumerable<T> param)
        {

            dynamic product = 1;
            foreach (var item in param)
            {
                product *= item;
            }

            return product;

        }
            
        public static T Avarage<T>(this IEnumerable<T> param)
        {
            int count = 0;
            dynamic sum = 0;
            foreach (var item in param)
            {
                sum+= item;
                count++;
            }

            return sum/count;
        }



        static void Main(string[] args)
        {
            double[] d = new double[5] { 3,1,2,4,7 };

            Console.WriteLine("Min : " + d.Min<double>());
            Console.WriteLine("Max : " + d.Max<double>());
            Console.WriteLine("Sum : " + d.Sum<double>());
            Console.WriteLine("Avarage : " + d.Avarage<double>());
            Console.WriteLine("Product : " + d.Product<double>());
           
        }
    }
}
