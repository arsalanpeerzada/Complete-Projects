using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int maxIndex = length - 1;
            int[] arrayOne = new int[length];
            int[] arrayTwo = new int[length];

            for (int i = 0; i < length; i++)
            {  
                Console.Write("Write number: ");
                arrayOne[i] = Convert.ToInt32(Console.ReadLine());
                arrayTwo[maxIndex] = arrayOne[i];
                maxIndex--;
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arrayOne[i]);
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arrayTwo[i]);
            }
        }
    }
}
