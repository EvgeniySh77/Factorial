using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int x = 20;
            Console.WriteLine(Factorial(x));

            Console.ReadKey();
        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
