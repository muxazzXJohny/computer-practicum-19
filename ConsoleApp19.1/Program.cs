using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1;
            int d = 4;  
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                int num = a1 + i * d;
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
