using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo yusra = new DirectoryInfo(@"C:\Users\Wali\Downloads\Desktop\movies");
            FileInfo[] File = yusra.GetFiles("*.txt");

            for (int i = 0; i < File.Length; i++)
            {
                Console.WriteLine(File[i]);
            }

           //string[]  atas=  File.ReadAllLines(@"C:\Users\Wali\Downloads\Desktop\new.txt");
           //for (int i = 0; i < atas.Length; i++)
           //{
           //    Console.WriteLine(atas[i]);
           //}
        }
    }
}
