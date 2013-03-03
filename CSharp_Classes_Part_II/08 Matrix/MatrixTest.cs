using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Matrix
{
    class MatrixTest
    {

        static void Main()
        {
            
            // First matrix

            Matrix<int> m1 = new Matrix<int>(3,6);

            for (int i = 0; i < m1.RowCapacity; i++)
            {
                for (int j = 0; j < m1.ColCapacity; j++)
                {
                    m1[i, j] = 3;
                    
                }
                
            }

            // Second matrix

            Matrix<int>  m2 = new Matrix<int>(3, 6);

            for (int i = 0; i < m2.RowCapacity; i++)
            {
                for (int j = 0; j < m2.ColCapacity; j++)
                {
                    m2[i, j] = 2;
                    
                }
               
            }

            Console.WriteLine("m1");
            Console.WriteLine(m1);
            Console.WriteLine("m2");
            Console.WriteLine(m2);
            
            // Third Matrix

            Matrix<int> m = new Matrix<int>(3, 6);

            Console.WriteLine("m1 + m2");
            m = m1 + m2;
            Console.WriteLine(m);
            

            Console.WriteLine("m1 - m2");
            m = m1 - m2;
            Console.WriteLine(m);
          

            Console.WriteLine("m1 * m2");
            m = m1 * m2;
            Console.WriteLine(m);
           
            
            // true operator

            Console.WriteLine("Cheking -m1- for zero elements:" );
            if (m1)
            {
                Console.WriteLine("There are not elements with value of 0 in this matrix");
            }

           // Matrix<int> m3 = new Matrix<int>(3, 3);
           // m = m1 + m3;


        }

        
    }
}
