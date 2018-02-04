using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholExchangeSimpleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            var rakiaPrice = whiskeyPrice / 2;
            var winePrice = rakiaPrice - (0.4 * rakiaPrice);
            var beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            var sumRakia = rakiaLiters * rakiaPrice;
            var sumWine = wineLiters * winePrice;
            var sumBeer = beerLiters * beerPrice;
            var sumWhiskey = whiskeyLiters * whiskeyPrice;

            var total = sumBeer + sumRakia + sumWhiskey + sumWine;
            Console.WriteLine("{0:f2}",total);


        }
    }
}
