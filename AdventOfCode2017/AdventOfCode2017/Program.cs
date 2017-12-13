using System;

namespace AdventOfCode2017
{
    public class Program
    {
        public static void Main()
        {
            ExecuteDay(new Day1());
        }

        public static void ExecuteDay(DayBase day)
        {
            try
            {
                Console.WriteLine($"{day.ClassName} COMMENCING");
                Console.WriteLine($"Result: {day.Calculate()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exeption of type {e.GetType()} occured.");
                Console.WriteLine($"\tMessage starts with: {e.Message.Substring(0, e.Message.Length < 120 ? e.Message.Length : 120)}");
            }
            finally
            {
                Console.WriteLine($"END OF {day.ClassName}");
                Console.WriteLine();
            }
        }
    }
}