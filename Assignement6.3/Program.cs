using System;

namespace Asignement6
{
    class Program

    {

        public static int CalculateSumRecursively(int n, int m)
        {
            if (m <= n)
            {
                return m;
            }
            else
            {
                return m + CalculateSumRecursively(n, m - 1);
            }
        }

        static void Main(string[] args)

        {

            Console.WriteLine("Enter number n: ");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number m: ");

            int m = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSumRecursively(n, m);

            Console.WriteLine(sum);

            Console.ReadKey();

        }

    }
}
