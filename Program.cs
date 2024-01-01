using System;

class CalendarProgram
{
    static void Main()
    {
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        Console.WriteLine("   Date                  Day");
        Console.WriteLine("-------------------------------");
        for (int i = 0; i < (int)startDate.DayOfWeek; i++)
        {
            Console.Write("   ");
        }

        while (startDate.Month == DateTime.Now.Month)
        {
            Console.Write($" {startDate.Day,2} ");
            if (startDate.DayOfWeek == DayOfWeek.Saturday)
                Console.WriteLine();
            startDate = startDate.AddDays(1);
        }
        Console.ReadLine();
    }
}
