using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diamond_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Stars *  :");
            int stars = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < stars; i++)
            {
                for (int j = 0; j < stars-i; j++)
                    Console.Write(' ');
                for (int j = 1; j <= i; j++)
                    Console.Write('*');
                for (int j = 1; j < i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
            for (int i = stars; i >= 1; i--)
            {
                for (int j = 0; j < (stars - i); j++)
                    Console.Write(' ');
                for (int j = 1; j <= i; j++)
                    Console.Write('*');
                for (int j = 1; j < i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }

        }
    }
}
