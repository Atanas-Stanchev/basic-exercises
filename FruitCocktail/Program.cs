using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCocktail
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());

            var sum = 0.00;
            
            
            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    sum = (2 * 56) * num ;
                }
                else if (size == "big")
                {
                    sum =( 5 * 28.70) * num;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    sum = (2 * 36.66) * num;
                }
                else if (size == "big")
                {
                    sum = (5 * 19.60) * num;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    sum = (2 * 42.10) * num;
                }
                else if (size == "big")
                {
                    sum = (5 * 24.80) * num;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    sum = (2 * 20) * num;
                }
                else if (size == "big")
                {
                    sum = (5 * 15.20) * num;
                }
            }
            var discount = 0.00;

            if (sum >= 400 && sum <= 1000)
            {
               discount = sum * 0.15;
               sum = sum - discount;
            }
            else if (sum > 1000)
            {
                discount = sum / 2;
                sum = Math.Abs(sum - discount);
            }
            
            Console.WriteLine("{0:f2} lv.",sum);

        }
    }
}
