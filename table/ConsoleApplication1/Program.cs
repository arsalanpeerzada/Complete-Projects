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
            Console.Write("Enter Number to Calculate Table:   ");
            int input=Convert.ToInt32(Console.ReadLine());
            Table table = new Table();
            table.Net(input);
        }

        class Table
        {
            public void Net(int _a)
            {

                for (int i = 1; i <= 10; i++)
                {
                    int result;
                    result = _a * i;
                    Console.WriteLine("{0} x {1} = {2}", _a, i, result);
                    
                }
            }
        }
    }
}
