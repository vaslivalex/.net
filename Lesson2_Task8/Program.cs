using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько секунд прошло с начала суток:");
            string sec = Console.ReadLine();
            int second = Convert.ToInt32(sec);
            int hours = second / 3600;
            Console.WriteLine("C начала суток прошло: {0} ч.", hours);
            Console.ReadKey();
        }
    }
}
