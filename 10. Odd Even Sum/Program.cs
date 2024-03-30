using System;

namespace _10.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int chislo = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sumOdd += chislo;
                }
                else
                {
                    sumEven += chislo;
                }
            }


            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                int diff = Math.Abs(sumOdd - sumEven);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
