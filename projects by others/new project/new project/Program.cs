using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace new_project
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("^^^Bundoo Khan Restaurant MENU^^^");
                Console.WriteLine("\nFOR : Monday");
                Console.WriteLine("Range: 15 – 50 >> Deal 01");
                Console.WriteLine("Range: 51 – 100 >> Deal 01 and Deal 02");
                Console.WriteLine("Range: 101 and more >> Deal 01, Deal 02, Deal 03 + complementary sweets");
                Console.WriteLine("\nFOR : Tuesday and Wednesday");
                Console.WriteLine("Range: 15 – 50 >> Deal 01");
                Console.WriteLine("Range: 51 – 100 >> Deal 01 and Deal 04");
                Console.WriteLine("Range: 101 and more >> Deal 01, Deal 04, Deal 05 + complementary shake");
                Console.WriteLine("\nFOR : Thursday & Friday");
                Console.WriteLine("Range: 15 – 50 >> Deal 01");
                Console.WriteLine("Range: 51 – 100 >> Deal 01 and Deal 06");
                Console.WriteLine("Range: 101 and more >> Deal 01, Deal 06, Deal 07 + complementary Falooda");
                Console.WriteLine("\nFOR : Weekends");
                Console.WriteLine("Range: 15 – 50 >> Deal 01 + complementary soup");
                Console.WriteLine("150 / person >> Buffet");
                Console.Write("\n\nPress Any Key To Continue >>>");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Enter Day: ");
                string day = Convert.ToString(Console.ReadLine());
                Console.Write("\nEnter Range: ");
                int range = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (day == "monday" && range >= 15 || range <= 50)
                {
                    Console.WriteLine("You can buy >> Deal 01");
                }
                else if (day == "monday" && range == 51 || range <= 100)
                {
                    Console.WriteLine("You can buy >> Deal 01 and Deal 02");
                }
                else if (day == "monday" && range >= 101)
                {
                    Console.WriteLine("You can buy >> Deal 01, Deal 02, Deal 03 + complementary sweets");
                }
                else if (day == "tuesday" || day == "wednesday" && range == 15 || range <= 50)
                {
                    Console.WriteLine("You can buy >> Deal 01");
                }
                else if (day == "tuesday" || day == "wednesday" && range == 51 || range <= 100)
                {
                    Console.WriteLine("You can buy >> Deal 01 and Deal 04");
                }
                else if (day == "tuesday" || day == "wednesday" && range >= 101)
                {
                    Console.WriteLine("You can buy >> Deal 01, Deal 04, Deal 05 + complementary shake");
                }
                else if (day == "thursday" || day == "friday" && range == 15 || range <= 50)
                {
                    Console.WriteLine("You can buy >> Deal 01");
                }
                else if (day == "thursday" || day == "friday" && range == 51 || range <= 100)
                {
                    Console.WriteLine("You can buy >> Deal 01 and Deal 06");
                }
                else if (day == "thursday" || day == "friday" && range >= 101)
                {
                    Console.WriteLine("You can buy >> Deal 01, Deal 06, Deal 07 + complementary Falooda");
                }
                else if (day == "weekends" && range == 15 || range <= 50)
                {
                    Console.WriteLine("You can buy >> Deal 01 + complementary soup");
                }
                else if (day == "weekends" && range >= 150)
                {
                    Console.WriteLine("Buffet");
                }
                else
                {
                    Console.WriteLine("Sorry you can not have any deal in this range, you can buy single items.");
                }
            }
        }
    }
}