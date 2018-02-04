using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheelsSongPass
{
    class ComplexForLoops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int pass = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (n == a * b + c * d)
                            {
                                if (a < b && c > d)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    pass++;
                                    if (pass == 4)
                                    {
                                        A = a;
                                        B = b;
                                        C = c;
                                        D = d;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (pass >= 4)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {A}{B}{C}{D}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
        }
    }
}
