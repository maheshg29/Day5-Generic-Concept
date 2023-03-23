using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_GenericConcept
{
    public class FindMinimum
    {
        public static void IntMin()
        {
            int[] arr = DeleteElement.GetIntElement();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Minimum value In Given Integer is " + arr[0]);
        }

        public static void FloatMin()
        {
            double[] arr = DeleteElement.GetDoubleElement();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Minimum value In Given Float is " + arr[0]);
        }

        public static void StringMin()
        {
            string[] strings=new string[3];
            Console.WriteLine("Please Enter String 1");
            strings[0] = Console.ReadLine();
            Console.WriteLine("Please Enter String 2");
            strings[1] = Console.ReadLine();
            Console.WriteLine("Please Enter String 3");
            strings[2] = Console.ReadLine();


            if (strings[0].Length < strings[1].Length && strings[0].Length < strings[2].Length)
            {
                Console.WriteLine("Minimum string is " + strings[0]);
            }
            else if (strings[1].Length < strings[0].Length && strings[1].Length < strings[2].Length)
            {
                Console.WriteLine("Minimum string is " + strings[1]);
            }
            else
                Console.WriteLine("Minimum string is " + strings[2]);
            
           
        }
    }
}
