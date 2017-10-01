using System;

namespace exDifferentNumbers
{
    class exDifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int noData = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = a + 1; j <= b; j++)
                {
                    for (int k = a + 2; k <= b; k++)
                    {
                        for (int l = a + 3; l <= b; l++)
                        {
                            for (int p = a + 4; p <= b; p++)
                            {
                                if (i < j && j < k && k < l && l < p)
                                {
                                    Console.Write(i + " " + j + " " + k + " " + l + " ");
                                    Console.WriteLine(p);
                                    noData = 1;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            if (noData == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
