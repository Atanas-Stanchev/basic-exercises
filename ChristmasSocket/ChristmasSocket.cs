using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasSocket
{
    class ChristmasSocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var row = 3 * n + 3;
            var widthOdd = 3 * n - 1;
            var widthEven = 3 * n - 4;
            // 3*3
            for (int i = 0; i < n - 2; i++)    // 8 // 14
            {
                if (n % 2 != 0)
                {
                    string line = new string('|', n - 2);
                    string dash = new string('-', 2 * n + 2);
                    Console.WriteLine($"{line}{dash}{line}");
                }

            }
            for (int a = 0; a < n - 2; a++)
            {
                string line = new string('|', n - 2);
                string dash = new string('-', widthOdd - 2);
                string star = new string('*', widthOdd - 2);
                Console.WriteLine($"{line}{star}{line}");
                Console.WriteLine($"{line}{dash}{line}");
                string wave = new string('~', widthOdd - 2);
                Console.WriteLine($"{line}{dash}{wave}{dash}{line}");
            }
        }
    }
}
