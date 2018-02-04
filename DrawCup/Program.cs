using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCup
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 5 * n;

            for (int i = 0; i < n / 2; i++)
            {
                string dots = new string ('.',n+i );
                string diez = new string('#', width - 2 * dots.Length);
                string firstPart = ($"{dots}{diez}{dots}");
                Console.Write(firstPart);
                Console.WriteLine();
            }
            for (int i = 0; i < n/2+1; i++)
            {
                string dots = new string('.', n + (n / 2) + i);
                string midDots = new string('.', width - 2 * dots.Length - 2);
                string secondPart = ($"{dots}#{midDots}#{dots}");
                Console.Write(secondPart);
                Console.WriteLine();
            }
            string dotsMidLine = new string('.', 2 * n);
            string diezMidLine = new string('#', n);
            string midLine = $"{dotsMidLine}{diezMidLine}{dotsMidLine}";
            Console.WriteLine(midLine);

            for (int i = 0; i < n/2; i++)
            {
                string diezBottom1 = new string('#', n + 4);
                string dotsBottom1 = new string('.', (width - diezBottom1.Length) / 2);
                string bottomPart1 = ($"{dotsBottom1}{diezBottom1}{dotsBottom1}");
                Console.Write(bottomPart1);
                Console.WriteLine();
            }

            string dotsDance = new string('.', (5 * n - 10) / 2);
            string dance = ($"{dotsDance}D^A^N^C^E^{dotsDance}");
            Console.Write(dance);
            Console.WriteLine();

            for (int i = 0; i < n/2+1; i++)
            {
                string diezBottom1 = new string('#', n + 4);
                string dotsBottom1 = new string('.',(width - diezBottom1.Length)/2);
                string bottoPart1 = ($"{dotsBottom1}{diezBottom1}{dotsBottom1}");
                Console.Write(bottoPart1);
                Console.WriteLine();

            }
        }
    }
}
