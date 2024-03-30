using System;

namespace _09.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersHalfCount = int.Parse(Console.ReadLine());

            int sum1 = 0;

            for (int i = 0; i < numbersHalfCount; i++)
            {
                sum1 += int.Parse(Console.ReadLine());
            }

            int sum2 = 0;

            for (int i = 0; i < numbersHalfCount; i++)
            {
                sum2 += int.Parse(Console.ReadLine());
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
