using System;

namespace Day_of_Weeka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday" };
            
            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(dayOfWeek[n - 1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
