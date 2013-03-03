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

//inserting element at given position, 

//clearing the list, 

//finding element by its value and ToString().

//Check all input parameters to
//avoid accessing elements at invalid positions.

//6. Implement auto-grow functionality: when the internal array is full,
//create a new array of double size and move all elements to it.

//7. Create generic methods Min<T>() and Max<T>() for finding 
//the minimal and maximal element in the  GenericList<T>. You may 
//need to add a generic constraints for the type T.



namespace _02_GenericList
{
    class GenericList<T> 
        
    {

        private T[] elements;
        private int count = 0;
       
        
       

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }
        
        public int Capacity
        { get {return elements.Length; } } 


        public int Count
        {
            get { return this.count; }
        }

        //Implement methods for adding element,

        public void Add(T element)
        {
            
            if (count >= elements.Length)
            {
                elements = AutoGrow(elements);
          

                //throw new IndexOutOfRangeException(String.Format(
               //"The list capacity of {0} was exceeded.", elements.Length));
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

        public void Remove(int index)
        {
            if (index >= this.Count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The index is outside of the range"));
            }

            for (int i = index + 1; i < elements.Length; i++)
            {
                elements[i - 1] = elements[i];
            }

            count--;

        }

        //inserting element at given position, 

        public void Insert(int index, T value)
        {
            
            if (index >= this.Count-1 )
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The index is outside of the  range"));
            }
            if (this.Count == this.Capacity)
            {
                 elements = AutoGrow(elements);
                //throw new IndexOutOfRangeException(String.Format(
                   // "All capacity is used!"));
            }

            count++;

           
            for (int i = this.Count - 1; i > index; i--)
            {
                elements[i] = elements[i-1];
                
            }

            elements[index] = value;

           
        }

        //clearing the list, 

        public void Clear()
        {
            this.elements = new T[this.Capacity];
            count = 0;
        }

        static T[] AutoGrow(T[] elements)
        {
            T[] temp = new T[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                temp[i] = elements[i];
            }

            elements = new T[temp.Length];
            elements = temp;
            temp = null;

            return elements;
        }

        //finding element by its value and ToString().

        public static int Find<U>(GenericList<U> elements, U value)
            where U : IComparable<U> 
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].CompareTo(value) == 0 )
                {
                    return i;
                }
                  
            }

            return -1; // If the element is not in the list 
        }
        // ToString

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < this.Count; i++)
			{
			   s+= this[i] + " ";

			}
            return s;
        }


        public static U Min<U>(GenericList<U> elements)
            where U : IComparable<U> 
        {

            U min = elements[0];
            for (int i = 0; i < elements.Count; i++)
            {
                if (min.CompareTo(elements[i]) >= 0)
                {
                    min = elements[i];
                }
            }

            return min;
        }

        public static U Max<U>(GenericList<U> elements)
           where U : IComparable<U>
        {

            U max = elements[0];
            for (int i = 0; i < elements.Count; i++)
            {
                if (max.CompareTo(elements[i]) <= 0)
                {
                    max = elements[i];
                }
            }

            return max;
        }
        
    }
}
