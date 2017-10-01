using System;


namespace exHotel
{
    class exHotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            var studioPrise = 0.00;
            var doublePrise = 0.00;
            var suitePrise = 0.00;
            switch (month)
            {
                case "May":
                case "October":
                    {
                        studioPrise = 50 * nights;
                        doublePrise = 65 * nights;
                        suitePrise = 75 * nights;
                        if (nights > 7)
                        {
                            if (month == "October")
                            {
                                studioPrise -= 50;
                            }
                            studioPrise = 0.95 * studioPrise;
                        }

                        break;
                    }
                case "June":
                case "September":
                    {
                        studioPrise = 60 * nights;
                        doublePrise = 72 * nights;
                        suitePrise = 82 * nights;
                        if (month == "September" && nights > 7)
                        {
                            studioPrise -= 60;
                        }
                        if (nights > 14)
                        {
                            doublePrise = 0.9 * doublePrise;
                        }
                        break;
                    }
                case "July":
                case "August":
                case "December":
                    {
                        studioPrise = 68 * nights;
                        doublePrise = 77 * nights;
                        suitePrise = 89 * nights;
                        if (nights > 14)
                        {
                            suitePrise = 0.85 * suitePrise;
                        }
                        break;
                    }
            }
            Console.WriteLine($" Studio: {studioPrise:F2} lv.");
            Console.WriteLine($" Double: {doublePrise:F2} lv.");
            Console.WriteLine($" Suite: {suitePrise:F2} lv.");
        }
    }
}
