using System;

namespace Rookies3Prime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetPrime(0, 50);
            GetPrime(51, 100);
            Console.ReadKey();
        }
        static async Task GetPrime(int min, int max)
        {
            await Task.Run(() =>
            {
                for (int i = min; i <= max; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(" " + i);
                    }
                }
            });
        }
        static bool IsPrime(int a)
        {
            bool isPrime = true;
            if (a < 2)
            {
                isPrime = false;
                return isPrime;
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        isPrime = false;
                        return isPrime;
                    }
                }
                isPrime = true;
                return isPrime;
            }
        }
    }
}