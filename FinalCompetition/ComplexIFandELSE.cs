using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class ComplexIFandELSE
    {
        static void Main(string[] args)
        {
            var dancers = int.Parse(Console.ReadLine());
            var points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double money = (dancers * points);
            double moneyAfterCosts = 0.0;
            double charity = 0.0;
            double cash = 0.0;
            double cashForDancers = 0.0;

            if (season == "summer" && place == "Abroad")
            {
                money += money * 0.50;
                moneyAfterCosts = money - (money * 0.10);
                charity = moneyAfterCosts * 0.75;
                cash = moneyAfterCosts - charity;
                cashForDancers = cash / dancers;
                Console.WriteLine("Charity - {0:f2}", charity);
                Console.WriteLine("Money per dancer - {0:f2}", cashForDancers);
            }
            else if (season == "winter" && place == "Bulgaria")
            {
                moneyAfterCosts = money - (money * 0.08);
                charity = moneyAfterCosts * 0.75;
                cash = moneyAfterCosts - charity;
                cashForDancers = cash / dancers;
                Console.WriteLine("Charity - {0:f2}", charity);
                Console.WriteLine("Money per dancer - {0:f2}", cashForDancers);
            }
            else if (season == "summer" && place == "Bulgaria")
            {
                moneyAfterCosts = money - (money * 0.05);
                charity = moneyAfterCosts * 0.75;
                cash = moneyAfterCosts - charity;
                cashForDancers = cash / dancers;
                Console.WriteLine("Charity - {0:f2}", charity);
                Console.WriteLine("Money per dancer - {0:f2}", cashForDancers);
            }
            if (season == "winter" && place == "Abroad")
            {
                money += money * 0.50;
                moneyAfterCosts = money - (money * 0.15);
                charity = moneyAfterCosts * 0.75;
                cash = moneyAfterCosts - charity;
                cashForDancers = cash / dancers;
                Console.WriteLine("Charity - {0:f2}", charity);
                Console.WriteLine("Money per dancer - {0:f2}", cashForDancers);
            }

        }
    }
}
