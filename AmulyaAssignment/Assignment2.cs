using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmulyaAssignment
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            DisplayOddAndEven(numbers);
        }
        static void DisplayOddAndEven(int[] arrays)
        {
            Console.WriteLine("Even Numbers:");
            foreach (int i in arrays)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\nOdd Numbers:");
            foreach(int i in arrays)
            {
                if(i % 2 == 1)
                    Console.Write(i + " ");
            }
        }
    }
}
