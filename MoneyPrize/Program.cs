using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double prize = double.Parse(Console.ReadLine());

            var points = 0;

            for (int i = 1; i <= n; i++)
            {
                var point = int.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    point *= 2;
                }
                points += point;
            }
            prize = points * prize;
            Console.WriteLine("The project prize was {0:f2} lv.",prize);
        }
    }
}
