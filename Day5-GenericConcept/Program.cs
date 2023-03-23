﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_GenericConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Concepts Problems");
            Console.WriteLine("Select any one option \n 1. Delete Int Element \n 2. Delete Double Element");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int[] intArry = DeleteElement.GetIntElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    DeleteElement.DeleteIntElement(intArry, delete);
                    break;

                case 2:
                    double[] doubleArry = DeleteElement.GetDoubleElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    double doubleDelete = Convert.ToDouble(Console.ReadLine());
                    DeleteElement.DeleteDoubleElement(doubleArry, doubleDelete);
                    break;

                default:
                    Console.WriteLine("Please Enter Right Option number From given List");
                    break;
            }
        }
    }
}
