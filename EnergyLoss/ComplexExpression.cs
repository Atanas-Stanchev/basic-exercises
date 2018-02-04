using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class ComplexExpression
    {
        static void Main(string[] args)
        {
            var numOfTrainDays = int.Parse(Console.ReadLine());
            var numOfDancers = int.Parse(Console.ReadLine());
            var energyOfDancer = 100.00;

            var energyOfEvenEven = 68.00;
            var energyOfEvenOdd = 65.00;
            var energyOfOddEven = 49.00;
            var energyOfOddOdd = 30.00;

            var totalEnergy = 0.0;
            var totalEnergyInDancesrs = numOfDancers * energyOfDancer * numOfTrainDays;
            var currentTotalEnergy = 0.0;
            for (int i = 1; i <= numOfTrainDays; i++)
            {
                var trainHour = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && trainHour % 2 == 0)
                {
                    totalEnergy = numOfDancers * energyOfEvenEven;
                }
                if (i % 2 == 0 && trainHour % 2 != 0)
                {
                    totalEnergy = numOfDancers * energyOfEvenOdd;
                }
                if (i % 2 != 0 && trainHour % 2 == 0)
                {
                    totalEnergy = numOfDancers * energyOfOddEven;
                }
                if (i % 2 != 0 && trainHour % 2 != 0)
                {
                    totalEnergy = numOfDancers * energyOfOddOdd;
                }

                currentTotalEnergy += totalEnergy;
            }
            var nonSpendEnergy = totalEnergyInDancesrs - currentTotalEnergy;
            var nonSpendEnergyByDancer = nonSpendEnergy / numOfDancers / numOfTrainDays;

            if (nonSpendEnergyByDancer <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {nonSpendEnergyByDancer:f2}");
            }
            else if (nonSpendEnergyByDancer > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {nonSpendEnergyByDancer:f2}");
            }






        }
    }
}
