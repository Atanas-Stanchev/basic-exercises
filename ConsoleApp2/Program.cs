using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // point on the line or out
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double point = double.Parse(Console.ReadLine());

            if (point > Math.Min(first, second) && point <
                Math.Max(first, second)
            {
                Console.WriteLine("ïn");
            }
            else
            {
                Console.WriteLine("out");
            }
            var firstDistance = Math.Abs(first - point);
            var secondDistance = Math.Abs(second - point);

            if (firstDistance < secondDistance)
            {
                Console.WriteLine(firstDistance);
            }
            else
            {
                Console.WriteLine(secondDistance);
            }
            /// another way
            ///
           /*
            var firstDistance = Math.Abs(first - point);
            var secondDistance = Math.Abs(second - point);

            Console.WriteLine(Math.Min (firstDistance, secondDistance));
            */
        }
    }
}