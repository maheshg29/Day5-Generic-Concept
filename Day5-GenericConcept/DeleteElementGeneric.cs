using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_GenericConcept
{
    public class DeleteElementGeneric<T>
    {
        T[] arr;
        T element;
        public DeleteElementGeneric(T[] arr, T element)
        {
            this.arr = arr;
            this.element = element;
        }

        public void RemoveElementFromArrayGeneric()
        {
            int k = 0;
            T[] result = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals(element))
                {
                    result[k] = arr[i];
                    k++;
                }
            }

            Console.WriteLine("\nResult After Delete Elemnet ");
            foreach (T j in result)
            {
                Console.Write(j + " ");
            }
        }
    }
}
