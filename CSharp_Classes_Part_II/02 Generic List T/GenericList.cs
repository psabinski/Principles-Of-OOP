using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a generic class GenericList<T> that keeps a list of elements
//of some parametric type T.

//Keep the elements of the list in an array
//with fixed capacity which is given as parameter in the class constructor. 


//Implement methods for adding element,

//accessing element by index, 

//removing element by index, 

//inserting element at given position, clearing the list, 
//finding element by its value and ToString(). Check all input parameters to
//avoid accessing elements at invalid positions.


namespace _02_Generic_List_T
{
    class GenericList<T> 
    {
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        //Implement methods for adding element,
        
        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capacity of {0} was exceeded.", elements.Length));
            }
            this.elements[count] = element;
            count++;
        }

        //accessing element by index,

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T current = elements[index];
                return current;
            }
        }

        //removing element by index, 

        public void Remove(T element, int index)
        {
            if (index >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The index is outside of the range"));
            }

            for (int i = index+1; i < elements.Length; i++)
            {
                elements[i - 1] = elements[i];
            }

            count--;
            
        }


    }
}
