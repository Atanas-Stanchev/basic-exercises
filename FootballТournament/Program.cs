using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballТournament
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacityStadium = double.Parse(Console.ReadLine());

            var fans = double.Parse(Console.ReadLine());

            var sectorA = 0.0;
            var sectorB = 0.0;
            var sectorV = 0.0;
            var sectorG = 0.0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();
                
                switch (sector)
                {
                    case "A": sectorA++;
                        break;
                    case "B": sectorB++;
                        break;
                    case "V":sectorV++;
                        break;
                    case "G": sectorG++;
                        break;
                }
            }
            sectorA = sectorA / fans * 100;
            sectorB = sectorB / fans * 100;
            sectorV = sectorV / fans * 100;
            sectorG = sectorG / fans * 100;


            Console.WriteLine("{0:f2}" + "%", sectorA);
            Console.WriteLine("{0:f2}" + "%", sectorB);
            Console.WriteLine("{0:f2}" + "%", sectorV);
            Console.WriteLine("{0:f2}" + "%", sectorG);
            Console.WriteLine("{0:f2}" + "%", (fans/capacityStadium)*100);


        }
    }
}
