using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length) 
//for the class StringBuilder that returns new StringBuilder and 
//has the same functionality as Substring in the class String.


namespace _01_Extention_Substring
{
    public static class SubstringExt
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int lenght)
        {
            StringBuilder subStr = new StringBuilder();

            for (int i = index; i < index + lenght; i++)
            {
                subStr.Append(sb[i].ToString());
            }

            return subStr;
        }

        static void Main(string[] args)
        {
            string s = "MickiMouseManagement";

            StringBuilder sb = new StringBuilder(s);

            Console.WriteLine(sb.SubString(0, 5).ToString());

            Console.WriteLine(sb.SubString(5, 5).ToString());

            Console.WriteLine(sb.SubString(10, 10).ToString());


        }
    }
}
