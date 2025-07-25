
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmulyaAssignment
{
    internal class Assignment4
    {
        static string GetStringvalue(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine().ToLower();
        }
        static int GetIntvalue(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        static float GetFloatvalue(string question)
        {
            Console.WriteLine(question);
            return float.Parse(Console.ReadLine());
        }
        static Array GenerateArray(string str, int size)
        {
            switch (str)
            {
                case "int":
                    int[] intArr = new int[size];
                    for (int i = 0; i < size; i++)
                        intArr[i] = GetIntvalue($"Enter element{i + 1}");
                    return intArr;
                case "float":
                    float[] floatArr = new float[size];
                    for (int i = 0; i < size; i++)

                        floatArr[i] = GetFloatvalue($"Enter elements{i + 1}");

                    return floatArr;
                case "string":
                    string[] stringArr = new string[size];
                    for (int i = 0; i < size; i++)
                        stringArr[i] = GetStringvalue($"Enter element{i + 1}");
                    return stringArr;

                default:
                    return null;
            }

        }

        static void ArrayInput()
        {
            int size = GetIntvalue("Enter the size of the array");
            String type = GetStringvalue("Enter the datatype of elements int,float,string");
            Array resultArray = GenerateArray(type, size);
            Console.WriteLine("The elements of array are");
            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            ArrayInput();
        }

    }
}
