using System;

namespace grandfatherStavri
{
    internal class grandFatherStavri
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double rakiaQuantity = 0;
            double degree = 0;
            double volDegree = 0;
            double totalQuantity = 0;
            double totalDegree = 0;
            double allDegree = 0;

            for (int i = 1; i <= n; i++)

            {
                rakiaQuantity = double.Parse(Console.ReadLine());
                degree = double.Parse(Console.ReadLine());
                totalQuantity += rakiaQuantity;
                volDegree = rakiaQuantity * degree;
                totalDegree += volDegree;
            }
            allDegree = totalDegree / totalQuantity;
            Console.WriteLine("Liter: {0:f2}", totalQuantity);
            Console.WriteLine("Degrees: {0:f2}", allDegree);
            if (allDegree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (allDegree >= 38 && allDegree <= 42)

            {
                Console.WriteLine("Super!");
            }
            else if (allDegree > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}