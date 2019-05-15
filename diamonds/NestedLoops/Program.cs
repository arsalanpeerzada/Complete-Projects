using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "";
         
              for (int i = 0; i < 10; i++)
                {
                    star += '*';
                    Console.WriteLine( star);
                }
              Console.ReadKey();
              for (int i = 0; i < 10; i++)
              {
                  for (int j = 0; j < i; j++)
                  {
                      Console.Write('*');
                  }
                  Console.WriteLine();
              }

        }
    }
}
















