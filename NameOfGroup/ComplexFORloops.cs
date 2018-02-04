using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfGroup
{
    class ComplexFORloops
    {
        static void Main(string[] args)
        {
            char bigLetter = char.Parse(Console.ReadLine());
            char smallLetter1 = char.Parse(Console.ReadLine());
            char smallLetter2 = char.Parse(Console.ReadLine());
            char smallLetter3 = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char a = 'A'; a <= bigLetter ; a++)
            {
                for (char b = 'a'; b <= smallLetter1;b ++)
                {
                    for (char c = 'a'; c <= smallLetter2; c++)
                    {
                        for (char d = 'a'; d <= smallLetter3; d++)
                        {
                            for (int i = 0; i <= number; i++)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter-1);



        }
    }
}
