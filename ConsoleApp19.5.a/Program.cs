using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10.0;
            int day = 1;
            double target = 20.0;

            while (distance <= target)
            {
                distance *= 1.1;
                day++;
            }

            Console.WriteLine($"На {day} день лыжник пробежит больше 20 км.");
           Console.ReadKey();
        }
    }
}

