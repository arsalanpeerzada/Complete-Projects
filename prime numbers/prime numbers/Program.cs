using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to chk whether prime or not.....");
            double input=Convert.ToInt32(Console.ReadLine());

            if (input==0 || input ==1)
            {
                Console.WriteLine("number is not prime");
            }

            else 
            {
                for (int i = 2; i <= input/2 ; i++)
                {
                    if (input%i==0)
                    {
                        Console.WriteLine(input+" is not prime");

                        return;
                    }
                    
                }
                Console.WriteLine(input + " is prime");
            }
        }
    }
}
