using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharitySimpleEx
{
    class Program
    {
        static void Main(string[] args)
        {

            var daysCampaign = int.Parse(Console.ReadLine());
            var confectioner = int.Parse(Console.ReadLine());
            var cakesNumbers = int.Parse(Console.ReadLine());
            var goffretsNumbers = int.Parse(Console.ReadLine());
            var pancakesNumbers = int.Parse(Console.ReadLine());

            double cakePrice = 45.00;
            double goffretPrice = 5.80;
            double pancakePrice = 3.20;

            var cakes = cakesNumbers * cakePrice;
            var goffrets = goffretsNumbers * goffretPrice;
            var pankaces = pancakesNumbers * pancakePrice;

            double sumDay = (cakes + goffrets + pankaces)*confectioner;
            double sumCampaign = sumDay * daysCampaign;
            double remain = sumCampaign /8;
            double remainsMoney = sumCampaign - remain;
            Console.WriteLine("{0:f2}",remainsMoney);

        }
    }
}
