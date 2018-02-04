using System;

namespace ConsoleApp1
{
    internal class Simple
    {
        private static void Main(string[] args)
        {
            double bricks = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            var bricksPerGo = capacity * workers;
            var bestRoute = bricks / bricksPerGo;

            Console.WriteLine(Math.Ceiling(bestRoute));
        }
    }
}