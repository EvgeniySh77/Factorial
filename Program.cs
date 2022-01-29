using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int x = 20;
            Console.WriteLine($"Факториал числа {x}\t" + Factorial(x));

            int n = 2;
            byte pow = 8;
            Console.WriteLine($"Число {n} возведенное в степень {pow}\t" + PowerUp(n, pow));

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

        public static int PowerUp(int n, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return n;
                }
                else
                {
                    return n * PowerUp(n, --pow);
                }
            }
        }
    }
}
