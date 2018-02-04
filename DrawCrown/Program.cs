using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCrown
{
    class Program
    {
        static void Main(string[] args)
        {
            /* one solution
            var n = int.Parse(Console.ReadLine());

            var w = (2 * n) - 1;
            var h = (n / 2) + 4;

            Console.Write("@");
            Console.Write(new string(' ', (w - 3) / 2));
            Console.Write("@");
            Console.Write(new string(' ', (w - 3) / 2));
            Console.WriteLine("@");


            Console.Write("**");
            Console.Write(new string(' ', (w - 5) / 2));
            Console.Write("*");
            Console.Write(new string(' ', (w - 5) / 2));
            Console.WriteLine("**");


            var sidedots = 1;
            var middleDots = 1;
            var intervals = (w - 6 - (2 * sidedots) - middleDots) / 2;

            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('.', sidedots));
                Console.Write("*");
                Console.Write(new string(' ', intervals));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string(' ', intervals));
                Console.Write("*");
                Console.Write(new string('.', sidedots));
                Console.WriteLine("*");

                sidedots++;
                middleDots += 2;
                intervals -= 2;
            }

            var dotsSideBot = n / 2 - 1;
            var dotsInBot = w - 4 - (2 * dotsSideBot);
            Console.Write("*");
            Console.Write(new string('.', dotsSideBot));
            Console.Write("*");
            Console.Write(new string('.', dotsInBot));
            Console.Write("*");
            Console.Write(new string('.', dotsSideBot));
            Console.WriteLine("*");

            Console.Write("*");
            Console.Write(new string('.', dotsSideBot + 1));
            Console.Write(new string('*', (w - 2 * dotsSideBot - 3 - 2) / 2));
            Console.Write(".");
            Console.Write(new string('*', (w - 2 * dotsSideBot - 3 - 2) / 2));
            Console.Write(new string('.', dotsSideBot + 1));
            Console.WriteLine("*");

            Console.WriteLine(new string('*', w));
            Console.WriteLine(new string('*', w));
            */

            // second solution

            int n = int.Parse(Console.ReadLine());

            var width = n * 2 - 1;
            var height = n / 2 + 4;
            var LeftRightdots = 1;
            var space = n - 5;
            var midDots = 1;
            var downMidDots = n / 2;


            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));
            for (int i = 1; i <= n - height + 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', LeftRightdots), new string(' ', space), new string('.', midDots));
                LeftRightdots++;
                space -= 2;
                midDots += 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n / 2 - 1), new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', n - downMidDots - 2));

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0}", new string('*', width));
            }
                
           //
                

        }
    }
}
