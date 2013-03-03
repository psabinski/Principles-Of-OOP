using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//Implement an indexer this[row, col] to access the inner matrix cells.


namespace _08_Matrix
{
    class Matrix<T>
     where T: IComparable<T>
    {
        
        private T[,] matrix;
        private int rCapacity;
        private int cCapacity;
       

        public Matrix(int rowCapacity, int colCapacity)
        {
            this.rCapacity = rowCapacity;
            this.cCapacity = colCapacity;
            matrix = new T[rCapacity, cCapacity];
        }

        public int RowCapacity
        {
            get { return this.rCapacity; } 
        }

        public int ColCapacity
        {
            get { return this.cCapacity; }
        }
        
       
        public T this[int row, int col]
        {
            get
            {
                if (row >= this.rCapacity)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid row index: {0}.", row));
                }
                if (col >= this.cCapacity)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid col index: {0}.", col));
                }

                T current = matrix[row,col];
                return current;
            }

            set
            {
                matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.ColCapacity != m2.ColCapacity) || (m1.RowCapacity != m2.RowCapacity))
            {
                throw new ArgumentException("The dimension of the matrix should be the same!");
            }
            Matrix<T> m = new Matrix<T>(m1.RowCapacity, m1.ColCapacity);

            for (int i = 0; i < m1.RowCapacity; i++)
            {
                for (int j = 0; j < m1.ColCapacity; j++)
                {
                    m[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }

            return m;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.ColCapacity != m2.ColCapacity) || (m1.RowCapacity!=m2.RowCapacity))
            {
                throw new ArgumentException("The dimension of the matrix should be the same!");
            }
            
            
            Matrix<T> m = new Matrix<T>(m1.RowCapacity, m1.ColCapacity);

            for (int i = 0; i < m1.RowCapacity; i++)
            {
                for (int j = 0; j < m1.ColCapacity; j++)
                {
                    m[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }

            return m;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.ColCapacity != m2.ColCapacity) || (m1.RowCapacity != m2.RowCapacity))
            {
                throw new ArgumentException("The dimension of both matrix should be the same!");
            }
            
            Matrix<T> m = new Matrix<T>(m1.RowCapacity, m1.ColCapacity);

            for (int i = 0; i < m1.RowCapacity; i++)
            {
                for (int j = 0; j < m1.ColCapacity; j++)
                {
                    m[i, j] = (dynamic)m1[i, j] * (dynamic)m2[i, j];
                }
            }

            return m;
        }

        public static bool operator true(Matrix<T> m)
        {
            for (int i = 0; i < m.RowCapacity; i++)
            {
                for (int j = 0; j < m.ColCapacity; j++)
                {
                    if (m[i,j].CompareTo((dynamic)(0)) == 0)
                    {
                        return false;
                    }
                }
                
            }

            return true;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (int i = 0; i < m.RowCapacity; i++)
            {
                for (int j = 0; j < m.ColCapacity; j++)
                {
                    if (m[i, j].CompareTo((dynamic)(0)) == 0)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public override string ToString()
        {
            string print = "";
            for (int i = 0; i < this.RowCapacity; i++)
            {
                for (int j = 0; j < this.ColCapacity; j++)
                {

                    print += this[i, j] + " ";
                }
                print += "\n";
            }


            return print;
        }

        
    
        


    }
}
