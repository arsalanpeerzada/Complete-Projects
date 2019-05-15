using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace choose_colour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("White on blue.");
            Console.WriteLine("Another line."); // <-- This line is still white on blue.
            Console.ResetColor();



           
        }
    }
}
