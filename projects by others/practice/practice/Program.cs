using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double A, B, C;

                Console.WriteLine("input Three Numbers and Press Enter after each.");
                A = Convert.ToDouble(Console.ReadLine());
                B = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());

                if (A < B && B < C)
                    Console.WriteLine(A + " < " + B + " < " + C);
                else if (A < C && C < B)
                    Console.WriteLine(A + " < " + C + " < " + B);
                else if (B < A && A < C)
                    Console.WriteLine(B + " < " + A + " < " + C);
                else if (B < C && C < A)
                    Console.WriteLine(B + " < " + C + " < " + A);
                else if (C < A && A < B)
                    Console.WriteLine(C + " < " + A + " < " + B);
                else if (C < B && B < A)
                    Console.WriteLine(C + " < " + B + " < " + A);
            }
        }
    }
}
