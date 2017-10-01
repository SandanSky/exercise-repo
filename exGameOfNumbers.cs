using System;

namespace exGameOfNumbers
{
    class exGameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;
            int combination = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magic)
                    {
                        first = i;
                        second = j;
                    }
                    combination++;
                }
            }
            if(first != 0)
            {
                Console.WriteLine($"Number found! {first} + {second} = {magic}");
            } else
            {
                Console.WriteLine($"{combination} combinations - neither equals {magic}");
            }
        }
    }
}
