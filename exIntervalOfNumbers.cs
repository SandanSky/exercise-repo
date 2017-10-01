using System;

namespace exIntervalOfNumbers
{
    class exIntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int smaller;
            if (num1 < num2) { smaller = num1; } else { smaller = num2; }
            for (int i = smaller; i <= (num1 + num2) - smaller; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
