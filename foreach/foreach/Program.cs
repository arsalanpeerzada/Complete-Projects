using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 words step by step:   ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            Words _arrange = new Words();
            _arrange.arranger(input1,input2,input3,input4);
        }
        class Words
        {
            public void arranger(string _input1, string _input2, string _input3, string _input4)
            {
                // An unsorted string array.
                string[] letters = { _input1, _input2, _input3, _input4 };
                // Use LINQ query syntax to sort the array alphabetically.
                var sorted = from letter in letters
                             orderby letter
                             select letter;
                // Loop with the foreach keyword.
                foreach (string value in sorted)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
