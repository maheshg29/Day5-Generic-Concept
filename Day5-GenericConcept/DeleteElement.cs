using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_GenericConcept
{
    public class DeleteElement
    {
        public static int size;
        public static void DeleteIntElement(int[] arry, int delete)
        {
            int k = 0;
            int[] result = new int[arry.Length - 1];

            for (int i = 0; i < arry.Length; i++)
            {
                if (delete != arry[i])
                {
                    result[k] = arry[i];
                    k++;
                }
            }
            Console.WriteLine("\nResult After Delete Elemnet ");
            foreach (int j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void DeleteDoubleElement(double[] arry, double delete)
        {
            int k = 0;
            double[] result = new double[arry.Length - 1];

            for (int i = 0; i < arry.Length; i++)
            {
                if (delete != arry[i])
                {
                    result[k] = arry[i];
                    k++;
                }
            }

            Console.WriteLine("\nResult After Delete Elemnet ");
            foreach (double j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static int[] GetIntElement()
        {
            Console.WriteLine("Enter How many elemet u want to add");
            DeleteElement.size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[DeleteElement.size];
            Console.WriteLine("Please enter element one by one");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static double[] GetDoubleElement()
        {
            Console.WriteLine("Enter How many elemet u want to add");
            DeleteElement.size = Convert.ToInt32(Console.ReadLine());
            double[] doubleArry = new double[DeleteElement.size];
            Console.WriteLine("Please enter Double element one by one");
            for (int i = 0; i < doubleArry.Length; i++)
            {
                doubleArry[i] = Convert.ToDouble(Console.ReadLine());
            }
            return doubleArry;
        }
    }
}


