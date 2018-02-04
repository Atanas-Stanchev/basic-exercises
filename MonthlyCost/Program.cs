using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyCost
{
    class Program
    {
        static void Main(string[] args)
        {
            double month = double.Parse(Console.ReadLine());
            double elMonthCost = 0.0;
            double electricity = 0.0;
            var water = 20.0 * month;
            var internet = 15.0 * month;
            var other = 0.0;
            var average = 0.0;

            for (int i = 0; i < month; i++)
            {
                elMonthCost = double.Parse(Console.ReadLine());
                electricity = electricity + elMonthCost;
                other = (water + internet + electricity);
                other += (other * 0.20);
                average = (electricity + water + internet + other) / month;
            }



            Console.WriteLine("Electricity: {0:f2} lv",electricity);
            Console.WriteLine("Water: {0:f2} lv",water);
            Console.WriteLine("Internet: {0:f2} lv",internet);
            Console.WriteLine("Other: {0:f2} lv",other);
            Console.WriteLine("Average: {0:f2} lv",average);


        }
    }
}
