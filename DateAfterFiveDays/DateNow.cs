using System;

namespace DateAfterFiveDays
{
    internal class DateNow
    {
        private static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            var year = DateTime.Now.Year;

            DateTime dateNow = new DateTime(2015, month, day); //2015 February
            var dateIn5Days = dateNow.AddDays(5);

            Console.WriteLine("{0}.{1:00}", dateIn5Days.Day, dateIn5Days.Month);
        }
    }
}