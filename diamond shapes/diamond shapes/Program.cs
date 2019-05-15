using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diamond_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for displaying pattern of *.");
            Console.Write("Enter the maximum number of *: ");
            int stars = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHere is the Diamond of Stars");

            for (int i = 1; i <= stars; i++)
            {
                for (int j = 0; j < (stars - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                for (int k = i-1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }

            for (int i = stars - 1; i >= 1; i--)
            {
                for (int j = 0; j < (stars - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                for (int k = i-1; k >= 1; k--)
                    Console.Write(k);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
