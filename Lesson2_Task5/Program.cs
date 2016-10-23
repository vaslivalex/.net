using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Среднеарифметическое значение двух чисел!");
            Console.WriteLine("Введите первое число:");
            string x1 = Console.ReadLine();
            int y1 = Convert.ToInt32(x1);
            Console.WriteLine("Введите второе число:");
            string x2 = Console.ReadLine();
            int y2 = Convert.ToInt32(x2);
            long midlSum = (y1 + y2) / 2;
            Console.WriteLine("Среднее арифметическое значение: {0}", midlSum);
            Console.ReadKey();

        }
    }
}
