using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class IvanoviFamily
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstChild = double.Parse(Console.ReadLine());
            double secondChild = double.Parse(Console.ReadLine());
            double thirdChild = double.Parse(Console.ReadLine());

            double sumGift = (firstChild + secondChild + thirdChild);
            double leftBudget = (budget - sumGift);
            leftBudget -= leftBudget * 0.10;
            Console.WriteLine("{0:f2}",leftBudget);



        }
    }
}
