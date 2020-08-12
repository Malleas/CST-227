using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 440;
            int number2 = 80;
            int answer = gcd(number1, number2);
            Console.WriteLine("The GCD of {0} and {1} is {2}", number1, number2, answer);
            Console.ReadLine();
        }

        static int gcd(int n1, int n2)
        {
            if(n2 == 0)
            {
                return n1;
            }else
            {
                Console.WriteLine("Not yet, Remainder is {0}", n1 % n2);
                return gcd(n2, n1 % n2);
            }
        }
    }
}
