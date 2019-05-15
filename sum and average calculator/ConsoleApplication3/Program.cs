using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum and average calculator.
            Console.WriteLine("No. of values: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int sum = 0;

            for (int i = 0; i < limit; i++)
            { 
                sum = sum + num[i];
            }
            Console.WriteLine("sum of all numbers: "+sum);

            int avg = sum / limit;

            Console.WriteLine("average: " +avg);
        }
    }
}
