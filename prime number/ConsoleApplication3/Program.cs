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
            /* local variable definition */
            int i, j;

            for (i = 1; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0)
                    {
                        break;
                    }
                 // if factor found, not prime
                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime", i);
                }
            }

            Console.ReadLine();
        }
    }
}
