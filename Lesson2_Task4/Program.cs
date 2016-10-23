using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны квадрата:");
            string x1 = Console.ReadLine();
            int x2 = Convert.ToInt32(x1);
            int per = x2 * 4;
            Console.WriteLine("Периметр квадрата равен: {0}", per);
            Console.ReadKey();
        }
    }
}
