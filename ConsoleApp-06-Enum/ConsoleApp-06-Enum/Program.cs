using System;

namespace ConsoleApp_06_Enum
{
    class Program
    {
        enum TempWeekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };

        enum MonthFull
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        };
        static void Main()
        {
            Console.WriteLine("Data types - Enumerated TYPES  ");
            TempWeekDays today = TempWeekDays.Monday;
            Console.WriteLine();
            Console.WriteLine("TempWeekDays.Monday : " + today);


            DateTime todaySDate = DateTime.Now;


            Console.WriteLine();
            Console.WriteLine("Today's date - fullname of the Months:");
            foreach (int value in Enum.GetValues(typeof(MonthFull)))
            {
                if (todaySDate.Month == (int)value)
                {
                    Console.WriteLine("{0} is month number {1}.", (MonthFull)value, (int)value);
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
