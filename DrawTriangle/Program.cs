using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            int width = (4 * N) + 1;
            int height = (2 * N) + 1;
            int dots = 1;
            int hash = 2 * N - 1;
            int spaces = 1;

            Console.WriteLine(new string('#', width));

            for (int row = 1; row <= N; row++)
            {
                if ((N / 2) + 1 == row)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                        new string('.', dots),
                        new string('#', hash),
                        new string(' ', (spaces - 3) / 2));
                    dots++;
                    hash -= 2;
                    spaces += 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', dots),
                        new string('#', hash),
                        new string(' ', spaces));
                    dots++;
                    hash -= 2;
                    spaces += 2;
                }



            }

            hash = 2 * N - 1;
            for (int row = 1; row <= N; row++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('#', hash));

                dots++;
                hash -= 2;
            }

        }
    }
}
