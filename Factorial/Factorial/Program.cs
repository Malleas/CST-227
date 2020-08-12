using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 6;
            Console.WriteLine(factorial(startingNumber));
            Console.ReadLine();
        }

        static int factorial(int n)
        {
            Console.WriteLine("X is {0}", n);
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
