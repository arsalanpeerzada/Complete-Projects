using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diamond2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                *
               ***
              *****
             *******
             
            */
            int numberOfRow = Convert.ToInt32(Console.ReadLine());  
            int numberOfSpaces = numberOfRow-1;
            int numberOfStars = numberOfRow - numberOfSpaces;

            for (int i = 0; i < numberOfRow; i++)
            {
                for (int j = 0; j < numberOfSpaces; j++)
                {
                    Console.Write(' ');
                }
                numberOfSpaces--;

                for (int k = 0; k < numberOfStars; k++)
                {
                    Console.Write('*');
                }
                numberOfStars = numberOfStars + 2;
                Console.WriteLine();
            }
        }
    }
}
