using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanoviWeekend
{
    class ivanoviWeekend
    {
        static void Main(string[] args)
        {
            var nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();

            double nightCost = 0.0;
            double transportCost = 0.0;
           


            if (destination == "Miami")
            {
                if (nights > 15)
                {
                    nightCost = (nights * (2 * 20.0 + 3 * 10.00));
                    nightCost += nightCost * 0.25;
                }
                else if (nights >= 11 && nights <= 15)
                {
                    nightCost = (nights * (2 * 22.99 + 3 * 11.99));
                    nightCost += nightCost * 0.25;
                }
                else if (nights <= 10)
                {
                    nightCost = (nights * (2 * 24.99 + 3 * 14.99));
                    nightCost += nightCost * 0.25;
                }
                switch (transport)
                {
                    case "train":
                        transportCost = (2 * 22.30) + (3 * 12.50);
                        break;
                    case "bus":
                        transportCost = (2 * 45.0) + (3 * 37.0);
                        break;
                    case "airplane":
                        transportCost = (2 * 90.0) + (3 * 68.50);
                        break;
                }
                Console.WriteLine("{0:f3}", nightCost + transportCost);
            }
            else if (destination == "Canary Islands")
            {
                if (nights > 15)
                {
                    nightCost = (nights * (2 * 28.0 + 3 * 22.00));
                    nightCost += nightCost * 0.25;
                }
                else if (nights >= 11 && nights <= 15)
                {
                    nightCost = (nights * (2 * 30.50 + 3 * 25.60));
                    nightCost += nightCost * 0.25;
                }
                else if (nights <= 10)
                {
                    nightCost = (nights * (2 * 32.50 + 3 * 28.50));
                    nightCost += nightCost * 0.25;
                }
                switch (transport)
                {
                    case "train":
                        transportCost = (2 * 22.30) + (3 * 12.50);
                        break;
                    case "bus":
                        transportCost = (2 * 45.0) + (3 * 37.0);
                        break;
                    case "airplane":
                        transportCost = (2 * 90.0) + (3 * 68.50);
                        break;
                }
                Console.WriteLine("{0:f3}", nightCost + transportCost);
            }
            else if (destination == "Philippines")
            {
                if (nights > 15)
                {
                    nightCost = (nights * (2 * 38.50 + 3 * 32.40));
                    nightCost += nightCost * 0.25;
                }
                else if (nights >= 11 && nights <= 15)
                {
                    nightCost = (nights * (2 * 41.00 + 3 * 36.00));
                    nightCost += nightCost * 0.25;
                }
                else if (nights <= 10)
                {
                    nightCost = (nights * (2 * 42.99 + 3 * 39.99));
                    nightCost += nightCost * 0.25;
                }
                switch (transport)
                {
                    case "train":
                        transportCost = (2 * 22.30) + (3 * 12.50);
                        break;
                    case "bus":
                        transportCost = (2 * 45.0) + (3 * 37.0);
                        break;
                    case "airplane":
                        transportCost = (2 * 90.0) + (3 * 68.50);
                        break;
                }
                Console.WriteLine("{0:f3}", nightCost + transportCost);
            }


        }
    }
}
