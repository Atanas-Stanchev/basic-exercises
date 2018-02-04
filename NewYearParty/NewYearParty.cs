using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearParty
{
    class NewYearParty
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            var cuvert = guests * 20;
            var donation =0.0;
            var fireworks =0.0;

            if (cuvert < budget)
            {
                budget -= cuvert;
                fireworks = Math.Round(budget * 0.40);
                donation = Math.Round(budget - fireworks);
                Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.",fireworks,donation);
                
            }
            else if (cuvert > budget) 
            {
                double moneyNeeded = Math.Round( cuvert - budget);
                Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.",moneyNeeded);
            }


        }
    }
}
