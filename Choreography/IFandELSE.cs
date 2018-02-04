using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class IFandELSE
    {
        static void Main(string[] args)
        {
           var steps = double.Parse(Console.ReadLine());
           var dancers = double.Parse(Console.ReadLine());
           var daysStudy = double.Parse(Console.ReadLine());

            double daySteps = Math.Ceiling((steps / daysStudy)/steps * 100);
            double percentSteps = (daySteps / dancers);

            if (daySteps <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", percentSteps); 
            }
            else 
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.",percentSteps);
            }
            
        }
    }
}
