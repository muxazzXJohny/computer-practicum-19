using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100; // первый взнос
            int d = 50;   // разность прогрессии
            int n = 10;   // количество месяцев
            int sum = 0;  // переменная для накопленной суммы

            for (int i = 0; i < n; i++)
            {
                int num = a + i * d; // вычисляем текущий взнос
                sum += num; // добавляем его в сумму
            }

            Console.WriteLine("Через 9 месяцев будет:" + sum + "р.");
            Console.ReadKey();

        }
    }
}
