using System;
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
                "7. Delete Int Element using Generic Class \n8. Delete Double Element using Generic Class \n9. Delete Char Element using Generic Class \n" +
                "\n \n ****Below Option for Minimum Number \n10. Find Minimum Integer value \n11. Find Minimum Float value \n12. Find Minimum String value \n" +
                "\n \n ****Below Option for Find Minimum Number Using Generic Methode \n 13. Int Number \n 14. Float Number \n 15. Find Minimum String Number\n" +
                "\n \n ****Below Option for Find Minimum Number Using Generic Class \n 16. Int Number \n 17. Float Number \n 18. Find Minimum String Number");
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

                case 8:
                    double[] doubleArryGenericClass = DeleteElement.GetDoubleElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    double doubleDeleteGenericClass = Convert.ToDouble(Console.ReadLine());
                    DeleteElementGeneric<double> deleteElementGeneric1 = new DeleteElementGeneric<double>(doubleArryGenericClass, doubleDeleteGenericClass);
                    deleteElementGeneric1.RemoveElementFromArrayGeneric();
                    break;

                case 9:
                    char[] charArryGenericClass = DeleteElement.GetCharElement();
                    Console.WriteLine("Plese pick up any one elemnt");
                    char charDeleteGenericClass = Convert.ToChar(Console.ReadLine());
                    DeleteElementGeneric<char> deleteElementGeneric2 = new DeleteElementGeneric<char>(charArryGenericClass, charDeleteGenericClass);
                    deleteElementGeneric2.RemoveElementFromArrayGeneric();
                    break;
                case 10:
                    FindMinimum.IntMin();
                    break;

                case 11:
                    FindMinimum.FloatMin();
                    break;
                case 12:
                    FindMinimum.StringMin();
                    break;
                case 13:
                    FindMinimum findMinimum1 = new FindMinimum();
                    findMinimum1.FindminimumGenerric<int>(DeleteElement.GetIntElement());
                    break;
                case 14:
                    FindMinimum findMinimum2 = new FindMinimum();
                    findMinimum2.FindminimumGenerric<double>(DeleteElement.GetDoubleElement());
                    break;

                case 15:
                    string[] strings = new string[3];
                    Console.WriteLine("Please Enter String 1");
                    strings[0] = Console.ReadLine();
                    Console.WriteLine("Please Enter String 2");
                    strings[1] = Console.ReadLine();
                    Console.WriteLine("Please Enter String 3");
                    strings[2] = Console.ReadLine();
                    int[] stringArrayCount = new int[3] { strings[0].Length, strings[1].Length, strings[2].Length, };
                    FindMinimum findMinimum3 = new FindMinimum();
                    findMinimum3.FindminimumGenerric<int>(stringArrayCount);
                    break;

                case 16:
                    MinimumGenericClass<int> minimumGenericClass = new MinimumGenericClass<int>(DeleteElement.GetIntElement());
                    minimumGenericClass.FindminimumGenerricClass();
                    break;

                case 17:
                    MinimumGenericClass<double> minimumGenericClass1 = new MinimumGenericClass<double>(DeleteElement.GetDoubleElement());
                    minimumGenericClass1.FindminimumGenerricClass();
                    break;

                case 18:
                    string[] strings1 = new string[3];
                    Console.WriteLine("Please Enter String 1");
                    strings1[0] = Console.ReadLine();
                    Console.WriteLine("Please Enter String 2");
                    strings1[1] = Console.ReadLine();
                    Console.WriteLine("Please Enter String 3");
                    strings1[2] = Console.ReadLine();
                    int[] stringArrayCount1 = new int[3] { strings1[0].Length, strings1[1].Length, strings1[2].Length };
                    MinimumGenericClass<int> minimumGenericClass2 = new MinimumGenericClass<int>(stringArrayCount1);
                    minimumGenericClass2.FindminimumGenerricClass();
                    break;


                default:
                    Console.WriteLine("Please Enter Right Option number From given List");
                    break;
            }
        }
    }
}
