using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            int REVERSE = 4;

            int [] array1 = new int[length];
            int[] array2 = new int[REVERSE];

            for (int i = 0; i < length; i++)
            {
                int user = Convert.ToInt32(Console.ReadLine());

                array1[i] = user;

                REVERSE--;

                array2[REVERSE] = user;


            }

            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array1[i]);
                
            }

            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array2[i]);
            }
             
            
        }
    }
}
