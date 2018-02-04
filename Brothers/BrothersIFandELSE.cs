using System;

namespace Brothers
{
    internal class BrothersIFandELSE
    {
        private static void Main(string[] args)
        {
            var brother1 = double.Parse(Console.ReadLine());
            var brother2 = double.Parse(Console.ReadLine());
            var brother3 = double.Parse(Console.ReadLine());
            var fishingFather = double.Parse(Console.ReadLine());

            var time = 1 / (1 / brother1 + 1 / brother2 + 1 / brother3);
            var allTime = time * 1.15;
            var timeLeft = fishingFather - allTime;

            if (timeLeft > 0)
            {
                Console.WriteLine("Cleaning time: {0:f2}", allTime);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",
                                  Math.Floor(timeLeft));
            }
            else
            {
                Console.WriteLine($"Cleaning time: {allTime:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(timeLeft))} hours.");
            }
        }
    }
}