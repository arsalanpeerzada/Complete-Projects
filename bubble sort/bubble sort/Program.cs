using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers & Get them sorted");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int input3 = Convert.ToInt32(Console.ReadLine());
            int input4 = Convert.ToInt32(Console.ReadLine());
            int input5 = Convert.ToInt32(Console.ReadLine());
            int input6 = Convert.ToInt32(Console.ReadLine());
            int input7 = Convert.ToInt32(Console.ReadLine()); 
            int input8 = Convert.ToInt32(Console.ReadLine());
            int input9 = Convert.ToInt32(Console.ReadLine());
            int input10 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { input1,input2,input3,input4,input5,input6,input7,input8,input9,input10};

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1 - write; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++) 
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
