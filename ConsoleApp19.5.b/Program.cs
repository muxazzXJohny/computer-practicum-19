using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._5.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dailyDistance = 10.0;
            double totalDistance = 0.0;
            int day = 0;

            while (totalDistance <= 100)
            {
                day++;
                totalDistance += dailyDistance;
                dailyDistance *= 1.1; 
            }

            Console.WriteLine($"На {day} день суммарный пробег будет больше 100 км.");
        }
    }
}
