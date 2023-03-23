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
            Console.WriteLine("Select any one option \n 1. Delete Int Element \n 2. Delete Double Element \n" +
                " 3. Delete Char Element \n \n ****Below Option for Generic Methode \n 4. Delete Int Element using Generic Method \n" +
                " 5. Delete Double Element using Generic Method \n 6. Delete Char Element using Generic Method \n \n ****Below Option for Generic Class \n" +
                "7. Delete Int Element using Generic Class");
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

                case 3:
                    char[] charArry = DeleteElement.GetCharElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    char charDelete = Convert.ToChar(Console.ReadLine());
                    DeleteElement.DeleteCharElement(charArry, charDelete);
                    break;

                case 4:
                    int[] intArryG = DeleteElement.GetIntElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    int deleteG = Convert.ToInt32(Console.ReadLine());
                    DeleteElement.RemoveElementFromArray<int>(intArryG, deleteG);
                    break;

                case 5:
                    double[] doubleArryG = DeleteElement.GetDoubleElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    double doubleDeleteG = Convert.ToDouble(Console.ReadLine());
                    DeleteElement.RemoveElementFromArray<double>(doubleArryG, doubleDeleteG);
                    break;

                case 6:
                    char[] charArryG = DeleteElement.GetCharElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    char charDeleteG = Convert.ToChar(Console.ReadLine());
                    DeleteElement.RemoveElementFromArray<char>(charArryG, charDeleteG);
                    break;
                case 7:
                    int[] intArryGenericClass = DeleteElement.GetIntElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    int deleteGenericClass = Convert.ToInt32(Console.ReadLine());
                    DeleteElementGeneric<int> deleteElementGeneric = new DeleteElementGeneric<int>(intArryGenericClass, deleteGenericClass);
                    deleteElementGeneric.RemoveElementFromArrayGeneric();
                    break;


                default:
                    Console.WriteLine("Please Enter Right Option number From given List");
                    break;
            }
        }
    }
}
