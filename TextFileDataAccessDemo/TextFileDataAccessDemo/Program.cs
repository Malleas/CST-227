using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demos\test.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
