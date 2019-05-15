using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Super Mart");
            /*char cash = 'P';
            char debit = 'D';
            char credit = 'C';
            char goods = 'R';*/
            Console.WriteLine("Press P for Cash");
            Console.WriteLine("Press D for Debit");
            Console.WriteLine("Press C for Credit");
            Console.WriteLine("Press R for return goods");

            char _input = Convert.ToChar(Console.ReadLine());

            Super _mart=new Super();
            _mart.mart(_input);
        }

        class Super
        {
            public int mart(int input)
            {
                Console.Clear();
                if (input == 'P')
                {
                    Console.WriteLine("Go to counter 01, 02, 05");
                }
                else if (input == 'D' || input == 'C')
                {
                    Console.WriteLine("Go to counter 03, 04");
                }
                else if (input == 'R')
                {
                    Console.WriteLine("Go to counter 06, 07");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                return 3;
          
            }
        }
    }
}
