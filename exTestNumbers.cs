using System;

namespace exTestNumbers
{
    class exTestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int num = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (totalSum >= max)
                    {
                        break;
                    }
                    totalSum += (i * j) * 3;
                    num++;
                   
                }
            }
            Console.WriteLine($"{num} combinations");
            if (totalSum >= max)
            {
                Console.WriteLine($"Sum: {totalSum} >= {max}");
            }
            else
            {
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
