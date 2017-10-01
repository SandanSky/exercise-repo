using System;

namespace exMagicLetter
{
    class exMagicLetter
    {
        static void Main(string[] args)
        {
            char let1 = Convert.ToChar(Console.ReadLine());
            char let2 = Convert.ToChar(Console.ReadLine());
            char let3 = Convert.ToChar(Console.ReadLine());

            for (char i = let1; i <= let2; i++)
            {
                for(char j = let1; j <= let2; j++)
                {
                    for (char k = let1; k <= let2; k++)
                    {
                        if (!(i == let3 || j == let3 || k == let3))
                            {
                            Console.Write(Char.ToString(i) + Char.ToString(j) + Char.ToString(k));
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
    }
}
