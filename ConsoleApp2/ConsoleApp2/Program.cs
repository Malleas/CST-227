using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            fun(4, 3);
            int fun(int x, int y)
            {
                if (x == 0)
                    return y;
                return fun(x - 1, x + y);
            }

          
            Console.ReadLine();
        }
    }
}
