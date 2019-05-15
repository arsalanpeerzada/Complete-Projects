using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace colour_changer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = Console.ReadLine();
                break;

            }
            Console.Clear();
            
            Console.WriteLine("Enter list to open colour list for fonts");
            

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                if (input == "list")
                {
                    Type type = typeof(ConsoleColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var name in Enum.GetNames(type))
                    {
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                        Console.WriteLine(name);
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    foreach (var name1 in Enum.GetNames(type))
                    {
                        Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name1);
                        Console.WriteLine(name1);
                    }

                    return;
                }
                    
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.Write("Error!: ");
        }
    }
}

